#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208020.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75A95BDF0F6F5BE463CD5FE3C24DEE338AB9ECF8"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM208020.aspx.cs"
using System;
using PX.Web.UI;
using PX.Olap.Maintenance;

public partial class Page_SM208020 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void gridProps_RowDataBound(object sender, PXGridRowEventArgs e)
	{
		if ((string)e.Row.DataKey.Value == "Expression") e.Row.EditorID = "edFormula";
	}
}

#line default
#line hidden
