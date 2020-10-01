#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL302010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9E689D1F6C2ED9F9C9B1ADBE67CFD0616B2C352C"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL302010.aspx.cs"
using System;
using System.Web.UI.WebControls;
using PX.Web.UI;


public partial class Page_GL302010 : PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{	
		for (int i = 1; ; i++)
		{
			string fieldName = "Period" + i;
			if (!ds.DataGraph.Caches["GLBudgetLine"].Fields.Contains(fieldName))
			{
				break;
			}

			PXGridColumn col = new PXGridColumn
			{
				DataField = fieldName,
				DataType = TypeCode.Decimal,
				Decimals = 2,
				TextAlign = HorizontalAlign.Right,
				AllowNull = false,
				RenderEditorText = true,
				AutoCallBack = true,
				Width = Unit.Pixel(70)
			};
			col.Header.Text = fieldName;
			var grid = sp1.FindControl("grid") as PXGrid;
			grid.Columns.Add(col);
		}
	}
}


#line default
#line hidden
