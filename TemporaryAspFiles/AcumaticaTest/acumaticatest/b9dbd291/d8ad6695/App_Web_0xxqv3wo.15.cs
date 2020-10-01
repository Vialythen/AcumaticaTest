#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\PR\PR504000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745D78F1B38B77D1E05B622FCB937461C827F4A9"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\PR\PR504000.aspx.cs"
using PX.Objects.PR;
using PX.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_PR_PR504000 : PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.Page.IsCallback)
		{
			bool downloadAuf = false;
			string downloadAufStrValue = this.QueryString[PRQueryParameters.DownloadAuf];
			if (!string.IsNullOrWhiteSpace(downloadAufStrValue))
			{
				bool.TryParse(downloadAufStrValue, out downloadAuf);
			}

			string errorCodeSetup =
				"const errSetup = \"" + RunReportProcessingError.SetupError + "\";" +
				"const errEinMissing = \"" + RunReportProcessingError.EinMissing + "\";" +
				"const errAatrixVendorIDMissing = \"" + RunReportProcessingError.AatrixVendorIDMissing + "\";" +
				"const errYearMissing = \"" + RunReportProcessingError.YearMissing + "\";" +
				"const errQuarterMissing = \"" + RunReportProcessingError.QuarterMissing + "\";" +
				"const errMonthMissing = \"" + RunReportProcessingError.MonthMissing + "\";" +
				"const errDateFromMissing = \"" + RunReportProcessingError.DateFromMissing + "\";" +
				"const errDateToMissing = \"" + RunReportProcessingError.DateToMissing + "\";" +
				"const errDateInconsistent = \"" + RunReportProcessingError.DateInconsistent + "\";" +
				"const errException = \"" + RunReportProcessingError.Exception + "\";" +
				"const reportingPeriodAnnual = \"" + GovernmentReportingPeriod.Annual + "\";" +
				"const reportingPeriodQuarterly = \"" + GovernmentReportingPeriod.Quarterly + "\";" +
				"const reportingPeriodMonthly = \"" + GovernmentReportingPeriod.Monthly + "\";" +
				"const reportingPeriodDateRange = \"" + GovernmentReportingPeriod.DateRange + "\";" +
				"const downloadAuf = " + downloadAuf.ToString().ToLowerInvariant() + ";" +
				"const sessionIdSeparator = \"" + PRGovernmentReportingProcess.SessionIdSeparator + "\";";
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "errorSetupKey", errorCodeSetup, true);
		}
	}
}

#line default
#line hidden
