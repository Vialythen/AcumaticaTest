#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203530.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC3190C4FFF01AC044859B6E22404E9C0D179318"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203530.aspx.cs"
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.UI;

public partial class Page_SM203530 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.Page.IsCallback)
		{
			//Register variable to perform user friendly grid row selecting
			PXGrid grid = this.gridCompanies;
			this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "gridCompaniesID", "var grdCompaniesID=\"" + grid.ClientID + "\";", true);
			this.Page.ClientScript.RegisterHiddenField("__FORCELOGOUT", "1");
		}
	}
}


#line default
#line hidden
