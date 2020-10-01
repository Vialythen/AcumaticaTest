#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\PR\PR201000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6124EB9AF93995AF6C36C8DE7A00F1EB97FAAD29"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\PR\PR201000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_PR201000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		PXCommandInfo fc = this.grid.ActionBar.Actions.FilesMenu;
		fc.Enabled = false;
	}
}


#line default
#line hidden
