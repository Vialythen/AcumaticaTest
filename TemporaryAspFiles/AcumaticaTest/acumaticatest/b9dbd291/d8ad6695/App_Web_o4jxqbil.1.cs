#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\BrowserWarning.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D01877C1AE7DD5DD10053F4888FE8158FFB58EAB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\BrowserWarning.aspx.cs"
using PX.Data;
using PX.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Frames_BrowserWarning : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
			this.lblUserAgent.Text = "User Agent: " + this.Request.UserAgent;

			PXLabel lbl = (PXLabel)form1.FindControl("lblMessage");
			lbl.Text = PXMessages.LocalizeFormatNoPrefix(PX.Data.ErrorMessages.SupportetBrowsers);
    }
}

#line default
#line hidden
