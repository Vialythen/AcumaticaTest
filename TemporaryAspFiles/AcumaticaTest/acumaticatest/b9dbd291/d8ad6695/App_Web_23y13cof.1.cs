#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201025.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47A7A6A8675B6261AC844D447B49461CF54FA4F7"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201025.aspx.cs"
using System;
using PX.Web.UI;

public partial class Page_SM203000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
        (sp1.FindControl("tree") as PXTreeView).DataBind();
	}
}


#line default
#line hidden
