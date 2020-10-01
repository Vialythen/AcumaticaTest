#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL201000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2673762C1AAB6A4F777829194396B24D76B44A3B"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL201000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_GL201000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		PXCommandInfo fc = this.grid.ActionBar.Actions.FilesMenu;
		fc.Enabled = false;
	}
}


#line default
#line hidden
