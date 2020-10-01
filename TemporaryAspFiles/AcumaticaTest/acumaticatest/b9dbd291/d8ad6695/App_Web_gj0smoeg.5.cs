#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208500.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72620E67BAF6C3832EA98CE3CD25EA1CE52A43D0"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208500.aspx.cs"
using PX.Data;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_SM208500 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}

	protected void grid_OnDataBound(object sender, EventArgs e)
	{
		LEPMaint graph = this.ds.DataGraph as LEPMaint;
		if (graph.IsSiteMapAltered)
			this.ds.CallbackResultArg = "RefreshSitemap";
	}
}


#line default
#line hidden
