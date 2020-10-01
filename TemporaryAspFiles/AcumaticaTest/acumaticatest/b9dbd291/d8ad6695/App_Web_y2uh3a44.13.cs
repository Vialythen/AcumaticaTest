#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP101000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2052D1B31D601C1BF09F3B9048F5FACCB3E695E"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\EP\EP101000.aspx.cs"
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.Objects.EP;
using PX.Web.UI;

public partial class Page_EP101000 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.IsCallback)
		{
			PXLabel lbl = this.tab.FindControl("lblPeriods") as PXLabel;
			if (lbl != null)
				lbl.Text = PXMessages.LocalizeNoPrefix(Messages.Periods);
		}
    }
}


#line default
#line hidden
