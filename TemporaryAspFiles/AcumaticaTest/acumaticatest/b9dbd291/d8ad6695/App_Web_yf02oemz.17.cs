#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203505.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B7CFD4CD65AB1D1784FB738D9B9BB2BBC67624A5"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203505.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using PX.Data;

public partial class Page_SM200578 : PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void grid_RowDataBound(object sender, PXGridRowEventArgs e)
	{
		if (e.Row != null && e.Row.DataItem != null)
		{
			PXStringState state = this.ds.DataGraph.Caches[e.Row.DataItem.GetType()].GetStateExt(e.Row.DataItem, "Value") as PXStringState;
			if (state != null && state.InputMask == "*")
				e.Row.Cells["Value"].IsPassword = true;
		}
	}
}


#line default
#line hidden
