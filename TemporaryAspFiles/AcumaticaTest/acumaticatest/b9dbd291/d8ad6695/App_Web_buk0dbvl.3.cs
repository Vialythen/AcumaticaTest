#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503021.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB1B33545189711E8F07E6C72C5674D8D1927AE9"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503021.aspx.cs"
using System;
using PX.Objects.CR;
using PX.Web.UI;

public partial class Page_CR503021 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}


	protected void wizard_OnSelectNextPage(object sender, PXWizardSelectPageEventArgs e)
	{
		UpdateContactMassProcess graph = ds.DataGraph as UpdateContactMassProcess;
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
