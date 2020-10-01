#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP503000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "827FFA40A0B5CCDAC03D583012F15BC8D1A73889"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP503000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.Objects.CS;
using PX.Web.UI;

public partial class Page_AP503000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if (PXAccess.FeatureInstalled<FeaturesSet.construction>())
		{
			PXGrid grid = tab.FindControl("grid1") as PXGrid;

			grid.SyncPosition = true;
		}
	}
}


#line default
#line hidden
