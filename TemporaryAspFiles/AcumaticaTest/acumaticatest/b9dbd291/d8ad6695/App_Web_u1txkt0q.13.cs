#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201020.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B696E20797041AB5C6A0F254446E2D36CFDE6365"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201020.aspx.cs"
using System;
using System.Web;
using PX.Web.Customization;

public partial class Page_AU201020 : PX.Web.UI.PXPage
{
	protected void Page_PreInit(object sender, EventArgs e)
	{
		ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);
	}

	protected void Page_Init(object sender, EventArgs e)
	{
        this.Master.FindControl("usrCaption").Visible = false;
    }
}


#line default
#line hidden
