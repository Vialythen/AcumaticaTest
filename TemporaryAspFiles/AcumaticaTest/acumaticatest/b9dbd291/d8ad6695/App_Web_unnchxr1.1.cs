#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204510.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B63677ADD6EEE69C15FC47A2FCFFD8CBA13ADC1A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204510.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.SM;

[Customization.CstDesignMode(Disabled=true)]
public partial class Page_SM204510 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.FindControl("usrCaption").Visible = false;
		//this.Master.CustomizationAvailable = false;
	}

	protected void gridVersions_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		//DummyProjRevision item = e.Row.DataItem as DummyProjRevision;
		//if (item == null) return;
		//if(item.ID == Guid.Empty)
		//    e.Row.Style.CssClass = "CssCurrent";
	}

	public void uploadPanel_Upload(PX.Web.UI.UserControls.PXUploadFilePanel.PXFileUploadedEventArgs args)
	{
		ProjectMaintenance.OnUploadPackage(args.FileName, args.BinData);

	}

}


#line default
#line hidden
