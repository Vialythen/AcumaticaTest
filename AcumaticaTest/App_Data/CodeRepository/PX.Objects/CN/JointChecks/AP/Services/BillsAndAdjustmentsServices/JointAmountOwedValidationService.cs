using System.Linq;
using PX.Data;
using PX.Objects.AP;
using PX.Objects.CN.Common.Extensions;
using PX.Objects.CN.JointChecks.AP.CacheExtensions;
using PX.Objects.CN.JointChecks.AP.DAC;
using PX.Objects.CN.JointChecks.Descriptor;

namespace PX.Objects.CN.JointChecks.AP.Services.BillsAndAdjustmentsServices
{
    public class JointAmountOwedValidationService
    {
        protected PXSelect<JointPayee> JointPayees;
        protected APInvoiceEntry Graph;
        private APInvoiceJCExt invoiceExtension;

        public JointAmountOwedValidationService(PXSelect<JointPayee> jointPayees, APInvoiceEntry graph)
        {
            JointPayees = jointPayees;
            Graph = graph;
        }

        protected APInvoice CurrentBill => Graph.Document.Current;

        protected APInvoiceJCExt InvoiceExtension =>
            invoiceExtension ?? (invoiceExtension =
                PXCache<APInvoice>.GetExtension<APInvoiceJCExt>(CurrentBill));

        public virtual void ValidateAmountOwed(JointPayee jointPayee)
        {
            ValidateTotalJointAmountOwed(jointPayee);
        }

        public virtual void RecalculateTotalJointAmount()
        {
            InvoiceExtension.TotalJointAmount = JointPayees.Select().FirstTableItems.Sum(jp => jp.JointAmountOwed);
        }

        protected virtual void ValidateTotalJointAmountOwed(JointPayee jointPayee)
        {
            var cashDiscount = CurrentBill.CuryOrigDiscAmt;
            if (InvoiceExtension.TotalJointAmount > CurrentBill.CuryLineTotal - cashDiscount)
            {
                ShowAmountOwedExceedsBillAmountException(jointPayee, cashDiscount == 0,
                    JointCheckMessages.AmountOwedExceedsBalance,
                    JointCheckMessages.AmountOwedExceedsBalanceWithCashDiscount);
            }
        }

        protected void ShowAmountOwedExceedsBillAmountException(JointPayee jointPayee, bool isCashDiscount,
            string messageWithoutCashDiscount, string messageWithCashDiscount)
        {
            var errorMessage = isCashDiscount
                ? messageWithoutCashDiscount
                : messageWithCashDiscount;
            JointPayees.Cache.RaiseException<JointPayee.jointAmountOwed>(jointPayee, errorMessage,
                jointPayee.JointAmountOwed);
            throw new PXException();
        }
    }
}