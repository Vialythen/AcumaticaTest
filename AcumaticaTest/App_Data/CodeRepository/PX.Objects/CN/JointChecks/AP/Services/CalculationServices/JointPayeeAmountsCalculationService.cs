using System.Collections.Generic;
using System.Linq;
using PX.Data;
using PX.Objects.CN.JointChecks.AP.DAC;
using PX.Objects.CN.JointChecks.AP.Services.DataProviders;

namespace PX.Objects.CN.JointChecks.AP.Services.CalculationServices
{
    public class JointPayeeAmountsCalculationService : CalculationServiceBase
    {
        public JointPayeeAmountsCalculationService(PXGraph graph)
            : base(graph)
        {
        }

        public decimal GetTotalJointAmountOwed(string referenceNumber, int? lineNumber = 0)
        {
            return JointPayeeDataProvider.GetJointPayees(Graph, referenceNumber, lineNumber)
                .Where(jp => jp.BillLineNumber == lineNumber).Sum(x => x.JointAmountOwed.GetValueOrDefault());
        }

        public decimal? GetJointPreparedBalance(JointPayee jointPayee,
            string referenceNumber = null, int? lineNumber = null)
        {
            var nonReleasedJointPayeePayments =
                GetNonReleasedJointPayeePayments(jointPayee, referenceNumber, lineNumber);
            var sumOfJointAmountToPay = nonReleasedJointPayeePayments.Sum(jpp => jpp.JointAmountToPay);
            return jointPayee.JointAmountOwed - jointPayee.JointAmountPaid - sumOfJointAmountToPay;
        }

        private IEnumerable<JointPayeePayment> GetNonReleasedJointPayeePayments(JointPayee jointPayee,
            string referenceNumber, int? lineNumber)
        {
            var nonReleasedJointPayeePayments = JointPayeePaymentDataProvider
                .GetNonReleasedJointPayeePayments(Graph, jointPayee);
            return referenceNumber == null
                ? nonReleasedJointPayeePayments
                : nonReleasedJointPayeePayments.Where(jpp =>
                    jpp.InvoiceRefNbr == referenceNumber && jpp.BillLineNumber == lineNumber);
        }
    }
}