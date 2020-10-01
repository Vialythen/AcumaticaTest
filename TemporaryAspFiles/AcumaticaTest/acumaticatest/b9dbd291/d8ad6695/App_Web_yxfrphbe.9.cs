#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM200520.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F551D4BA0584E647C32E5921EA92D639E4B2F496"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM200520.aspx.cs"
using System;
using PX.SiteMap.Graph;

public partial class Page_SM200520 : PX.Web.UI.PXPage
{
    protected void form_DataBound(object sender, EventArgs e)
    {
        SiteMapMaint graph = this.ds.DataGraph as SiteMapMaint;
        if (graph.IsSiteMapAltered)
            this.ds.CallbackResultArg = "RefreshSitemap";
    }
}


#line default
#line hidden
