#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP301010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FC64D1E7ABB56B733A76871F7FC937ED6F459E1A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP301010.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Objects.EP;

public partial class Page_EP301010 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		var graph = this.ds.DataGraph as ExpenseClaimDetailMaint;

		if (graph != null)
		{
			ExpenseClaimDetailEntry.ExpenseClaimDetailEntryExt.CheckAllowedUser(graph);
		}
	}
}


#line default
#line hidden
