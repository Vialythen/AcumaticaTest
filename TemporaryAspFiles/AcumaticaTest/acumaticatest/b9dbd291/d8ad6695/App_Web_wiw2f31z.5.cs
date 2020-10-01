#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503220.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1133257CBD9346FDD4FD65410837D1E5B7CBD692"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR503220.aspx.cs"
using System;
using PX.Objects.CR;
using PX.Web.UI;

public partial class  Page_CR503220 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void wizard_OnSelectNextPage(object sender, PXWizardSelectPageEventArgs e)
	{
		UpdateCaseMassProcess graph = ds.DataGraph as UpdateCaseMassProcess;
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
