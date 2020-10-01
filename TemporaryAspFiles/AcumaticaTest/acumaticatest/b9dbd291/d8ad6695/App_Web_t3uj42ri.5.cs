#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503320.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F5ED3CC809EDCF3A86AB538D3CC5718C6C37B147"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503320.aspx.cs"
using System;
using PX.Objects.CR;
using PX.Web.UI;

public partial class Page_CR503320 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}
	
	protected void wizard_OnSelectNextPage(object sender, PXWizardSelectPageEventArgs e)
	{
		UpdateBAccountMassProcess graph = ds.DataGraph as UpdateBAccountMassProcess;
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
