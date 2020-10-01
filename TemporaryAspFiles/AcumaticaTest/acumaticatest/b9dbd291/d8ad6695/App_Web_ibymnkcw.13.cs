#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203030.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7980BC05F358B1E1AE766926B66C9DA6FCABBB0A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM203030.aspx.cs"
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PX.Data.Wiki.Parser;
using PX.Web.UI;

public partial class Page_SM203030 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		this.Master.PopupWidth  = 900;
		this.Master.PopupHeight = 600;
		PXWikiEdit edit = this.FindControl("edBody") as PXWikiEdit;
		if(edit != null)	edit.PreviewSettings = new PXWikiSettings(this).Relative;
	}
}


#line default
#line hidden
