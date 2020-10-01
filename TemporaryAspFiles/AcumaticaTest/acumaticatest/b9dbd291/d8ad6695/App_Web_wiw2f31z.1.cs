#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503120.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "758F83BC79A4F330AD3D83904FB81F4DF6A6BA02"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503120.aspx.cs"
using System;
using PX.Objects.CR;
using PX.Web.UI;

public partial class  Page_CR503120 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void wizard_OnSelectNextPage(object sender, PXWizardSelectPageEventArgs e)
	{
		UpdateOpportunityMassProcess graph = ds.DataGraph as UpdateOpportunityMassProcess;
		if (graph == null) return;

		graph.RestrictAttributesByClass();
		if (!graph.Attributes.AllowSelect)
		{
			e.NextPage = 2;
		}
	}
}


#line default
#line hidden
