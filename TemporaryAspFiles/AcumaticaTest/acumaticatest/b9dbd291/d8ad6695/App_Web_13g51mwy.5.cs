#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CO409061.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F4AAE6E0785183D75A3FDE829E1122141D6E7B8C"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CO409061.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_CO409061 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.gridAnnouncements.FilterShortCuts = true;
		this.gridAnnouncements.ActionBar.Actions.AddNew.Enabled = false;
		this.gridAnnouncements.ActionBar.Actions.Delete.Enabled = false;
	}
}


#line default
#line hidden
