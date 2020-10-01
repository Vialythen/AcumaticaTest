using System;
using System.Collections.Generic;
using PX.Data;
using PX.Objects.AP;
using PX.Objects.CN.JointChecks.AP.DAC;
using PX.Objects.CN.JointChecks.AP.GraphExtensions.PreparePayments;
using PX.Objects.CN.JointChecks.AP.Services.CalculationServices;
using PX.Objects.CN.JointChecks.AP.Services.DataProviders;
using PX.Objects.CN.JointChecks.Descriptor;
using PX.Objects.Common.Extensions;

namespace PX.Objects.CN.JointChecks.AP.Services.PreparePaymentsServices
{
	public class AmountToPayValidationService
	{
		protected readonly APPayBills ApPayBills;
		protected readonly ApPayBillsExt ApPayBillsExt;
		private JointPayeeAmountsCalculationService jointPayeeAmountsCalculationService;
		private VendorPreparedBalanceCalculationService vendorPreparedBalanceCalculationService;
		private AmountToPayCalculationService amountToPayCalculationService;
		private InvoiceBalanceCalculationService invoiceBalanceCalculationService;

		public AmountToPayValidationService(APPayBills apPayBills)
		{
			ApPayBills = apPayBills;
			ApPayBillsExt = apPayBills.GetExtension<ApPayBillsExt>();
			InitializeCalculationServices();
		}

		private IEnumerable<JointPayeePayment> JointPayeePayments => ApPayBillsExt.JointPayeePayments.SelectMain();

		private APAdjust Adjustment => ApPayBillsExt.Adjustments.Current;

		public void ValidateJointPayeePayment(PXCache cache, JointPayeePayment jointPayeePayment)
		{
			try
			{
				ValidateJointAmountToPay(jointPayeePayment);
			}
			catch (Exception exception)
			{
				PXUIFieldAttribute.SetError<JointPayeePayment.jointAmountToPay>(cache,
					jointPayeePayment, exception.Message, jointPayeePayment.JointAmountToPay?.ToString());
				return;
			}
			cache.ClearFieldErrors<JointPayeePayment.jointAmountToPay>(jointPayeePayment);
		}

		public void ValidateVendorAmountToPay(decimal? amountToPay)
		{
			ValidateNegativeAmount(amountToPay);
			ValidateAmountToPayExceedsVendorBalance(amountToPay);
			var totalAmountToPay = amountToPay + amountToPayCalculationService.GetJointAmountToPay(
				ApPayBills.APDocumentList.Current.AdjdLineNbr);
			var invoiceBalance = invoiceBalanceCalculationService.GetInvoiceBalance(ApPayBills.APDocumentList.Current);
			ValidateTotalAmountToPay(totalAmountToPay, invoiceBalance);
		}

		private void ValidateAmountToPayExceedsVendorBalance(decimal? amountToPay)
		{
			var vendorPreparedBalance =
				vendorPreparedBalanceCalculationService.GetVendorPreparedBalance(ApPayBills.APDocumentList.Current);
			if (amountToPay > vendorPreparedBalance)
			{
				throw new PXSetPropertyException(JointCheckMessages.AmountPaidExceedsVendorBalance,
					vendorPreparedBalance);
			}
		}

		private void ValidateJointAmountToPay(JointPayeePayment jointPayeePayment)
		{
			ValidateNegativeAmount(jointPayeePayment.JointAmountToPay);
			ValidateJointAmountToPayExceedsJointBalance(jointPayeePayment);
			ValidateTotalAmountToPay(jointPayeePayment);
		}

		private static void ValidateNegativeAmount(decimal? amountToPay)
		{
			if (amountToPay < decimal.Zero)
			{
				throw new PXSetPropertyException(JointCheckMessages.ValueCanNotBeNegative);
			}
		}

		private void ValidateJointAmountToPayExceedsJointBalance(JointPayeePayment jointPayeePayment)
		{
			var jointPayee = JointPayeeDataProvider.GetJointPayee(ApPayBills, jointPayeePayment);
			var jointPreparedBalance = jointPayeeAmountsCalculationService.GetJointPreparedBalance(jointPayee,
				Adjustment.AdjdRefNbr, Adjustment.AdjdLineNbr);
			if (jointPayeePayment.JointAmountToPay > jointPreparedBalance)
			{
				throw new PXSetPropertyException(JointCheckMessages.JointAmountToPayExceedsJointPayeeBalance);
			}
		}

		private void ValidateTotalAmountToPay(JointPayeePayment jointPayeePayment)
		{
			var totalAmountToPay = amountToPayCalculationService.GetTotalAmountToPay(jointPayeePayment, Adjustment);
			ValidateTotalAmountToPay(totalAmountToPay, invoiceBalanceCalculationService.GetInvoiceBalance(Adjustment));
		}

		private static void ValidateTotalAmountToPay(decimal? totalAmountToPay, decimal? invoiceBalance)
		{
			if (totalAmountToPay > invoiceBalance)
			{
				throw new PXSetPropertyException(JointCheckMessages.TotalAmountExceedsVendorBalance, invoiceBalance);
			}
		}

		private void InitializeCalculationServices()
		{
			var isPaymentByLines = ApPayBillsExt.CurrentBill.Current?.PaymentsByLinesAllowed == true;
			jointPayeeAmountsCalculationService = new JointPayeeAmountsCalculationService(ApPayBills);
			vendorPreparedBalanceCalculationService = new VendorPreparePaymentPreparedBalanceCalculationService(ApPayBills);
			amountToPayCalculationService = isPaymentByLines
				? new AmountToPayPerLineCalculationService(ApPayBills, JointPayeePayments)
				: new AmountToPayCalculationService(ApPayBills, JointPayeePayments);
			invoiceBalanceCalculationService = isPaymentByLines
				? new InvoiceLineBalanceCalculationService(ApPayBills)
				: new InvoiceBalanceCalculationService(ApPayBills);
		}
	}
}