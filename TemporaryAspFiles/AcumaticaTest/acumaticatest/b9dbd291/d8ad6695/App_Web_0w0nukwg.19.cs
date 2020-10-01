#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201055.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8CAC652AF89233E078B37F251C5B8F89289FC5C6"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201055.aspx.cs"
using System;
using PX.Web.UI;

public partial class Page_SM201055 : PX.Web.UI.PXPage
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
