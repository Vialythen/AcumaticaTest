#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN402000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68D5A738A40CDF6EA7FFF084EA00C636B49EA109"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN402000.aspx.cs"
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.UI;
using PX.Data;
using PX.Objects.IN;

public partial class Page_IN402000 : PX.Web.UI.PXPage
{
	const string BoldTextStyle = "BoldText";

	protected void Page_Init(object sender, EventArgs e)
	{
		Style style = new Style();
		style.Font.Bold = true;
		this.Page.Header.StyleSheet.CreateStyleRule(style, this, "." + BoldTextStyle);

		this.Master.PopupWidth = 960;
		this.Master.PopupHeight = 600;
	}

	protected void AdditionDeductionGrids_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		var item = e.Row.DataItem as PX.Objects.IN.InventoryQtyByPlanType;
		if (item != null && item.IsTotal.GetValueOrDefault())
		{
			e.Row.Style.CssClass = BoldTextStyle;
		}
	}
}


#line default
#line hidden
