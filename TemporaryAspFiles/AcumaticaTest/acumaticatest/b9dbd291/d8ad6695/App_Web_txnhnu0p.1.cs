#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CO409000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC4B9759C110C5ED621518DF1988FD437BC74D4E"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CO409000.aspx.cs"
using System;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Objects.EP;

public partial class Pages_CO409000 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		Style style = new Style();
		style.Font.Bold = true;
		this.Page.Header.StyleSheet.CreateStyleRule(style, this, ".SubjBold");
	}

	protected void grid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		PXResult record = e.Row.DataItem as PXResult;
		if (record == null) return;

		EPView viewInfo = (EPView)record[typeof(EPView)];
		bool isBold = viewInfo != null && (viewInfo.Status == null || viewInfo.Status == EPViewStatusAttribute.NOTVIEWED);
		if (isBold) e.Row.Style.CssClass = "SubjBold";
	}
}

#line default
#line hidden
