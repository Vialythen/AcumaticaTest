#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CM\CM101000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24D8A2F81CF440AE1462886A6C86646BDC437CBB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CM\CM101000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.Web.UI;
using PX.Objects.CM;

public partial class Page_CM101000 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.IsCallback)
		{
			PXLabel lbl = this.formSettings.FindControl("lblPeriodsNumberAfter") as PXLabel;
			if (lbl != null)
				lbl.Text = PXMessages.LocalizeNoPrefix(Messages.Periods);
		}
	}
}


#line default
#line hidden
