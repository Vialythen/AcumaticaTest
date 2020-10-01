#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C29615D2C009B694C3B3FB9E9F2590BC0F4ECCF"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP301000.aspx.cs"
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

public partial class Page_EP301000 : PX.Web.UI.PXPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
		this.Master.PopupHeight = 700;
		this.Master.PopupWidth = 900;
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		var graph = this.ds.DataGraph as ExpenseClaimEntry;

		if (graph != null)
		{
			ExpenseClaimDetailEntry.ExpenseClaimDetailEntryExt.CheckAllowedUser(graph);
		}
	}
	
}


#line default
#line hidden
