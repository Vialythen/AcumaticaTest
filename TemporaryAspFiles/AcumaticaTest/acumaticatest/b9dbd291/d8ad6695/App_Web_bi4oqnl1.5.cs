#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN203500.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EC1ED52097819E7CBCC970A1EB35EAF1DCB6D9D4"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN203500.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_IN203500 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		InventoryMatrixEntry.CreateItemsPage_AddStyles(this);
	}

	protected void MatrixMatrix_RowDataBound(object sender, PXGridRowEventArgs e)
	{
		InventoryMatrixEntry.CreateItemsPage_RowDataBound(e.Row);
	}

	protected void MatrixMatrix_ColumnsGenerated(object sender, EventArgs e)
	{
		InventoryMatrixEntry.CreateItemsPage_ColumnsGenerated(MatrixMatrix.Columns);
	}

	protected void MatrixAttributes_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixAttributes.Columns, 0);
	}

	protected void MatrixMatrix_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixMatrix.Columns);
	}
}



#line default
#line hidden
