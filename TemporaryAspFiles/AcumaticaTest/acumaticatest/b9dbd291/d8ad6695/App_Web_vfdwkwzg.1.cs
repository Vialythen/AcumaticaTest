#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\CstPublished\pages_so\SO301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4CCCFD6F96A1DB80CDB7426E2CA8A511AE8E3CF"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\CstPublished\pages_so\SO301000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using PX.Objects;
using PX.Objects.IN.Matrix.DAC.Unbound;
using System.Linq;

public partial class Page_SO301000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		Master.PopupWidth = 950;
		Master.PopupHeight = 600;

		// panel = (PXFormView)this.PanelAddSiteStatus.FindControl("formSitesStatus");
	}

	protected void MatrixAttributes_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixAttributes.Columns, 0);
	}

	protected void MatrixMatrix_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixMatrix.Columns);
	}

	protected void MatrixItems_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.InsertAttributeColumnsByTemplateColumn(
			MatrixItems.Columns, ds.DataGraph.Caches[typeof(MatrixInventoryItem)].Fields);
	}
}


#line default
#line hidden
