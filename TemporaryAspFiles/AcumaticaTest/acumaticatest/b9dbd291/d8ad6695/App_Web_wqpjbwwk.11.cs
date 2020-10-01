#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS209000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409F859A47717527FE72E4869895763DB5CCAE31"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS209000.aspx.cs"
using System;
using PX.Data;
using PX.Web.UI;
using PX.Objects.CS;

public partial class Page_CS209000 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!PXAccess.FeatureInstalled<FeaturesSet.payrollModule>())
			HideUnpaidTimeControls();
	}

	private void HideUnpaidTimeControls()
	{
		PXLabel unpaidTimeLabel = (PXLabel)tab.FindControl("PXUnpaidTimeLabel");
		if (unpaidTimeLabel != null)
			unpaidTimeLabel.Visible = false;

		PXLayoutRule layoutRule = (PXLayoutRule)tab.FindControl("PXUnpaidTimeLayoutRule");
		if (layoutRule != null)
			layoutRule.StartColumn = false;
	}
}


#line default
#line hidden
