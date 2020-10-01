#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201510.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5920824A5BF0A61FBFC0AB518077386A697C2DE6"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201510.aspx.cs"
using System;
using PX.Web.UI;
using PX.Data;
using System.Web;
using System.Web.UI.WebControls;

public partial class Pages_SM_SM201510 : PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
		PXLabel label = frmInstall.FindControl("lblDisclamer") as PXLabel;
		label.Text = PX.Data.PXMessages.LocalizeNoPrefix(PX.Data.ActionsMessages.LicenseDisclamer).Replace(Environment.NewLine, "<BR>");
		label.AlreadyLocalized = true;

		PXLabel warning = frmWarning.FindControl("edWarningText") as PXLabel;
		warning.Text = PX.Data.PXMessages.LocalizeNoPrefix(PX.SM.Messages.LSWarningMessage).Replace(Environment.NewLine, "<BR>");
		warning.AlreadyLocalized = true;

		PXLabel agreement = frmAgreement.FindControl("edAgreementText") as PXLabel;
		agreement.Text = PX.Data.PXMessages.LocalizeNoPrefix(PX.SM.Messages.LicenseEulaConfirmation).Replace(Environment.NewLine, "<BR>");
		agreement.AlreadyLocalized = true;

		HyperLink agreementLink = frmAgreement.FindControl("eulaLink") as HyperLink;
		agreementLink.Text = PX.Data.PXMessages.LocalizeNoPrefix(PX.SM.Messages.LicenseEulaAgreementLink);

		string licenseType = (string)HttpContext.Current.Session["LicenseType"];
		if(!string.IsNullOrEmpty(licenseType))
		{
			var link = frmAgreement.FindControl("eulaLink") as HyperLink;
			link.Target = "_blank";
			link.NavigateUrl = string.Format("~/EULA/{0}.pdf", licenseType.ToLower());
		}
	}
}


#line default
#line hidden
