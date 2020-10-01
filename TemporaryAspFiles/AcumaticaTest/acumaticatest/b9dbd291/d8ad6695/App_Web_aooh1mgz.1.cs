#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2CCB9F5299C2C51156DBA8C79DC7937AD59F6ADA"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208010.aspx.cs"
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.UI;
using PX.Olap.Maintenance;

public partial class Page_SM208010 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void gridProps_RowDataBound(object sender, PXGridRowEventArgs e)
	{
		if ((string)e.Row.DataKey.Value == "Expression") e.Row.EditorID = "edFormula";
	}

	protected void form_DataBound(object sender, EventArgs e)
	{
		PivotMaint graph = this.ds.DataGraph as PivotMaint;
		if (graph.IsSiteMapAltered)
			this.ds.CallbackResultArg = "RefreshSitemap";
	}
}

#line default
#line hidden
