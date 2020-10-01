#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP402000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65C7B3FDF9C7BFC72664FE7ED77E68012CC5059E"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP402000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_AP402000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.grid.FilterShortCuts = true;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		PXToolBar toolBar = this.ds.ToolBar;
		toolBar.Items.RemoveAt(0);
	}
}


#line default
#line hidden
