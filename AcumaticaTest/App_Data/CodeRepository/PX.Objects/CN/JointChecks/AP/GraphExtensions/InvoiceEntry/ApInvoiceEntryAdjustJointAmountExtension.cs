using System;
using System.Collections.Generic;
using System.Linq;
using PX.Common;
using PX.Data;
using PX.Objects.AP;
using PX.Objects.CN.Common.Extensions;
using PX.Objects.CN.Common.Services;
using PX.Objects.CN.JointChecks.AP.CacheExtensions;
using PX.Objects.CN.JointChecks.AP.DAC;
using PX.Objects.CN.JointChecks.AP.Services.CalculationServices;
using PX.Objects.CN.JointChecks.Descriptor;
using PX.Objects.CS;

namespace PX.Objects.CN.JointChecks.AP.GraphExtensions.InvoiceEntry
{
	public class ApInvoiceEntryAdjustJointAmountExtension : PXGraphExtension<ApInvoiceEntryExt, APInvoiceEntry>
	{
		public PXAction<APInvoice> AdjustJointAmounts;

		private IEnumerable<JointPayee> JointPayees => Base1.JointPayees.Select().FirstTableItems;

		private APInvoiceJCExt InvoiceExtension =>
			PXCache<APInvoice>.GetExtension<APInvoiceJCExt>(Base.Document.Current);

		private bool IsAdjustingInProgress => InvoiceExtension?.IsAdjustingJointAmountsInProgress == true;

		public static bool IsActive()
		{
			return PXAccess.FeatureInstalled<FeaturesSet.construction>() &&
				!SiteMapExtension.IsTaxBillsAndAdjustmentsScreenId();
		}

		[PXUIField(DisplayName = "Adjust Joint Amounts",
			MapEnableRights = PXCacheRights.Update, MapViewRights = PXCacheRights.Select)]
		[PXButton]
		public virtual void adjustJointAmounts()
		{
			SetOriginalValuesForJoinPayees();
			InvoiceExtension.IsAdjustingJointAmountsInProgress = true;
		}

		[PXOverride]
		public virtual void Persist(Action baseHandler)
		{
			baseHandler();
			if (Base.Document.Current != null)
			{
				InvoiceExtension.IsAdjustingJointAmountsInProgress = false;
			}
		}

		public virtual void _(Events.RowSelected<APInvoice> args)
		{
			if (args.Row == null)
			{
				return;
			}
			AdjustJointAmounts.SetEnabled(IsAdjustJointAmountActionAvailable());
			Base1.JointPayees.AllowUpdate = Base1.JointPayees.AllowUpdate || IsAdjustingInProgress;
		}

		public virtual void _(Events.RowSelected<JointPayee> args)
		{
			var jointPayee = args.Row;
			if (jointPayee == null)
			{
				return;
			}
			ModifyJointPayeeFieldsAvailability(jointPayee);
		}

		public virtual void _(Events.RowPersisting<APInvoice> args)
		{
			if (args.Operation != PXDBOperation.Delete && IsAdjustingInProgress)
			{
				ValidateJointPayees();
			}
		}

		private void ModifyJointPayeeFieldsAvailability(JointPayee jointPayee)
		{
			SetJointPayeeFieldEnabled<JointPayee.jointPayeeInternalId>(jointPayee, !IsAdjustingInProgress);
			SetJointPayeeFieldEnabled<JointPayee.jointPayeeExternalName>(jointPayee, !IsAdjustingInProgress);
			SetJointPayeeFieldEnabled<JointPayee.billLineNumber>(jointPayee, !IsAdjustingInProgress);
			SetJointPayeeFieldEnabled<JointPayee.jointAmountOwed>(
				jointPayee, !IsAdjustingInProgress || jointPayee.OriginalJointBalance > 0);
		}

		private void SetJointPayeeFieldEnabled<TField>(JointPayee jointPayee, bool isEnabled)
			where TField : IBqlField
		{
			PXUIFieldAttribute.SetEnabled<TField>(Base1.JointPayees.Cache, jointPayee, isEnabled);
		}

		private bool IsAdjustJointAmountActionAvailable()
		{
			var isAnyJointPayeeWithPositiveBalance = JointPayees.Any(jp => jp.JointBalance > 0);
			var isOpenStatus = Base.Document.Current?.Status == APDocStatus.Open;
			return isAnyJointPayeeWithPositiveBalance && isOpenStatus && !IsAdjustingInProgress;
		}

		private void ValidateJointPayees()
		{
			if (JointPayees.Select(ValidateJointAmountOwed).ToList().Any(isValidated => !isValidated))
			{
				throw new PXException(ErrorMessages.RecordRaisedErrors, null, Base1.JointPayees.Cache.DisplayName);
			}
		}

		private bool ValidateJointAmountOwed(JointPayee jointPayee)
		{
			RemoveJointAmountOwedValidation(jointPayee);
			if (jointPayee.JointAmountOwed < decimal.Zero)
			{
				Base1.JointPayees.Cache.RaiseException<JointPayee.jointAmountOwed>(jointPayee,
					JointCheckMessages.TheValueMustNotBeLesserThanZero,
					jointPayee.JointAmountOwed);
				return false;
			}
			var minValue = jointPayee.OriginalJointAmountOwed - jointPayee.OriginalJointPreparedBalance;
			var maxValue = jointPayee.OriginalJointAmountOwed;
			if (jointPayee.JointAmountOwed < minValue || jointPayee.JointAmountOwed > maxValue)
			{
				RaiseValidationException(jointPayee, minValue);
				return false;
			}
			return true;
		}

		private void RemoveJointAmountOwedValidation(JointPayee jointPayee)
		{
			Base1.JointPayees.Cache.GetAttributes<JointPayee.jointAmountOwed>(jointPayee)
				.OfType<PXUIVerifyAttribute>().ForEach(attr => attr.CheckOnRowPersisting = false);
		}

		private void RaiseValidationException(JointPayee jointPayee, decimal? minValue)
		{
			var message = string.Format(JointCheckMessages.CorrectionToThisAmountIsNotAvailable, minValue);
			Base1.JointPayees.Cache.RaiseException<JointPayee.jointAmountOwed>(
				jointPayee, message, jointPayee.JointAmountOwed);
		}

		private void SetOriginalValuesForJoinPayees()
		{
			var jointPayeeAmountsCalculationService = new JointPayeeAmountsCalculationService(Base);
			foreach (var jointPayee in JointPayees)
			{
				jointPayee.OriginalJointAmountOwed = jointPayee.JointAmountOwed;
				jointPayee.OriginalJointPreparedBalance = jointPayeeAmountsCalculationService.GetJointPreparedBalance(jointPayee);
				jointPayee.OriginalJointBalance = jointPayee.JointBalance;
			}
		}
	}
}