#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\WZ\WZ202000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E37B86D5AAE4CDFA935BE97051B44BC652747A17"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\WZ\WZ202000.aspx.cs"
using System;
using PX.Data;
using PX.Objects.WZ;
using PX.SM;
using PX.Web.UI;

public partial class Page_WZ202000 : PXPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void taskFeatures_DataBound(object sender, PXGridRowEventArgs e)
    {
        WZTaskFeature feature = (WZTaskFeature)e.Row.DataItem;

        if (feature.Offset != null && feature.Offset > 0)
            e.Row.Cells["DisplayName"].Style.CssClass = "PropOffset" + feature.Offset;
    }
}


#line default
#line hidden
