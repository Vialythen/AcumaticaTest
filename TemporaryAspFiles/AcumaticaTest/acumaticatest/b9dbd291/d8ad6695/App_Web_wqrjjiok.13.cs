#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM207035.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02D2A309E3EB8D03FD8E9D0ADF2208CDFAF29CE2"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM207035.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_SM207035 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if (!this.Page.IsCallback)
		{
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "gridPreparedID", "var gridPreparedID=\"" + this.gridPreparedData.ClientID + "\";", true);
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "pnlPreparedDataID", "var pnlPreparedDataID=\"" + this.pnlPreparedData.ClientID + "\";", true);
		}
		this.gridPreparedData.RepaintColumns = true;
	}
}


#line default
#line hidden
