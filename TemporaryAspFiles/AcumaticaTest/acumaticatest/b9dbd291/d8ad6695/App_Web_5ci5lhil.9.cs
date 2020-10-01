#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\MobileAuth.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724E80E74EBCD9F97A8A4B1024F1DA4898355472"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\MobileAuth.aspx.cs"
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Data;

public partial class Frames_MobileAuth : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var request = HttpContext.Current.Request;
        var locale = request.QueryString["locale"];
        if(!string.IsNullOrWhiteSpace(locale))
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(locale);
        var result = request.QueryString["result"];
        string login = "temp";
        if (PXDatabase.Companies.Length > 0)
        {
            string company =  PXDatabase.Companies[0];
            login += "@" + company;
        }
        using (new PXLoginScope(login, PXAccess.GetAdministratorRoles()))
        {
            if (string.Equals(result, "success", StringComparison.OrdinalIgnoreCase))
            {
                lblSuccess.Visible = true;
                imgSuccess.Visible = true;
                lblSuccess.Text =
                    PX.Data.PXMessages.LocalizeNoPrefix(PX.AscxControlsMessages.MobileAuthScreen
                        .AuthenticationSuccessfull);
            }

            if (string.Equals(result, "fail", StringComparison.OrdinalIgnoreCase))
            {
                lblFail.Visible = true;
                imgFail.Visible = true;
                lblFail.Text =
                    PX.Data.PXMessages.LocalizeNoPrefix(PX.AscxControlsMessages.MobileAuthScreen.AuthenticationFailed);
            }
        }
    }
}

#line default
#line hidden
