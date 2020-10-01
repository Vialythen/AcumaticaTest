#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM205010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A02A0766EC336C6F96DD01E69BB95A70FF3375A8"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM205010.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_SM205010 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.Page.IsCallback)
		{
			PX.Web.UI.PXTextEdit editor = this.frmViewXml.FindControl("edDetailsXml") as PX.Web.UI.PXTextEdit;
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "pnlViewXmlID", "var pnlViewXmlID=\"" + this.pnlViewXml.ClientID + "\";", true);
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "frmID", "var frmID=\"" + this.frmViewXml.ClientID + "\";", true);
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "txtID", "var txtID=\"" + editor.ClientID + "\";", true);
		}
	}
}


#line default
#line hidden
