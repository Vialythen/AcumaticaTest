#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL104000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3927089E946A2A3AA27ED0492217859D9DB93B3A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL104000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_GL104000 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PX.Web.UI.PXGrid grid = this.tab.FindControl("gridUsers") as PX.Web.UI.PXGrid;
		if (grid != null)
		{
			grid.ActionBar.Actions.EditRecord.Text = PX.Objects.GL.Messages.Membership;
			grid.ActionBar.Actions.EditRecord.Tooltip = PX.Objects.GL.Messages.ttipMembership;
		}
	}
}


#line default
#line hidden
