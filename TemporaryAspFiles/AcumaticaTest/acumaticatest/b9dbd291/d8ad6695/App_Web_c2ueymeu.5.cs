#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN401500.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91815432C51F58F733765C1A37DFA659021059EB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN401500.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using System.Linq;

public partial class Page_IN401500 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void MatrixAttributes_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixAttributes.Columns, 0);
	}

	protected void MatrixMatrix_AfterSyncState(object sender, EventArgs e)
	{
		InventoryMatrixEntry.EnableCommitChangesAndMoveExtraColumnAtTheEnd(MatrixMatrix.Columns, null, "ViewAllocationDetails");
	}
}


#line default
#line hidden
