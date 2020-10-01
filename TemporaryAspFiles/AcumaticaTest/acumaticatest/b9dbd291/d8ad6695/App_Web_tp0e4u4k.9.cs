#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\Adapters.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03B42D7D46978DB0713E7F4F78EDDC02444CB20C"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\Adapters.aspx.cs"
using System;
using PX.Api;

public partial class Api_Adapters : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(IsPostBack)
			return;

		//EditDocument.Text = DescriptionStorage.Xml;
	}
	protected void SaveButton_Click(object sender, EventArgs e)
	{
		//DescriptionStorage.Xml = EditDocument.Text;
	}
	protected void ImportButton_Click(object sender, EventArgs e)
	{
		//DescriptionStorage.ImportTrace();
		//EditDocument.Text = DescriptionStorage.Xml;



	}
	protected void ButtonTestExport_Click(object sender, EventArgs e)
	{
		//TestDataset.Export(@"d:\tmp\_export.xml");
	}
	protected void ButtonTestImport_Click(object sender, EventArgs e)
	{
		//TestDataset.Import(@"d:\tmp\_export.xml", @"d:\tmp\_import_log.xml");

	}
}


#line default
#line hidden
