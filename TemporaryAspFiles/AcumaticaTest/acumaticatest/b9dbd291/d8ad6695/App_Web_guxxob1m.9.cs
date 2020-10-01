#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503020.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5655E76BD81FEF9A2B5259C7DF8025BB768FEE13"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503020.aspx.cs"
using System;
using PX.Objects.CR;
using PX.Web.UI;

public partial class Page_CR503020 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}


	protected void wizard_OnSelectNextPage(object sender, PXWizardSelectPageEventArgs e)
	{
		UpdateLeadMassProcess graph = ds.DataGraph as UpdateLeadMassProcess;
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
