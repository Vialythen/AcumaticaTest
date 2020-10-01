#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM207036.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FB9F594E71EF03B04FAEF8385670B87680161B1C"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM207036.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using PX.Api;

public partial class Page_SM207036 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PXGrid grid = this.tab.FindControl("gridPreparedData") as PXGrid;
		if (grid != null)
		{
			grid.RepaintColumns = true;
			grid.GenerateColumnsBeforeRepaint = true;
		}
	}

	protected void upl_FileUploaded(object sender, PXFileUploadEventArgs e)
	{
		((SYImportProcessSingle)this.ds.DataGraph).SaveNewFileVersion(e.UploadedFile);
	}
}


#line default
#line hidden
