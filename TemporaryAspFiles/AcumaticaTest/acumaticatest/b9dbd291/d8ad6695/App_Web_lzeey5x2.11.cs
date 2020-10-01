#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203520.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F65AF0A3BF6F2876B877364B31D6E355315F64A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203520.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Common;
using PX.Data;
using PX.SM;
using PX.Web.UI;

public partial class Page_SM200575 : PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.Page.IsCallback) this.Page.ClientScript.RegisterHiddenField("__FORCELOGOUT", "1");
		this.Master.PopupWidth = 960;
		this.Master.PopupHeight = 700;
	}

	protected void OnFileUploadFinished(PX.Web.UI.UserControls.PXUploadFilePanel.PXFileUploadedEventArgs e)
	{
		CompanyMaint graph = (CompanyMaint)this.ds.DataGraph;
		try
		{
			graph.OnPackageUploaded(e.FileName, e.Password, e.BinData);
		}
		catch (PXException ex)
		{
			this.ClientScript.RegisterClientScriptBlock(this.GetType(), "uploadErr", "window.uploadErr = \"Error during file upload: " + ex.MessageNoPrefix.Replace('"', '\'') + "\";", true);
			throw;
		}
	}
}


#line default
#line hidden
