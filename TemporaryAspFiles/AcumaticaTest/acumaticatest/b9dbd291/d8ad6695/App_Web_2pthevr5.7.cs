#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP506000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4E7CF195F9448FD69480EF745D7DD68FF64C5A0F"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP506000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Objects.EP;
using PX.Web.UI;

public partial class Page_EP506000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.PopupHeight = 300;
		this.Master.PopupWidth = 700;
	}

	protected void grid_OnLoad(object sender, EventArgs e)
	{
		PXGrid grid = (PXGrid) sender;
		grid.ActionBar.Position = ActionsPosition.None;
	}
}


#line default
#line hidden
