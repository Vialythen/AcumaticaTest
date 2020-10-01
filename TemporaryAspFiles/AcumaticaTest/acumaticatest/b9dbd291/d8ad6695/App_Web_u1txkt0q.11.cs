#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201060.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054CD2640D296BF66913C3F80F90B55255D55D07"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201060.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.Customization;

public partial class Pages_AU_AU201060 : PX.Web.UI.PXPage
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
