#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\TX\TX206000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98542DC740B307798CBAE806578E6DB425AC7C46"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\TX\TX206000.aspx.cs"
using System;
using PX.Web.UI;

public partial class Page_TX206000 : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PXTab tab = this.PXTab1; 
		this.Page.ClientScript.RegisterClientScriptBlock(GetType(), "tab1ID", "var tab1ID=\"" + tab.ClientID + "\";", true);			
	}
}


#line default
#line hidden
