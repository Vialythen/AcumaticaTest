#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\WZ\WZ201520.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BD9CB476C20A749D72620061D2D245CC3DD3051"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\WZ\WZ201520.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Common;
using PX.Data;
using PX.Objects.WZ;
using PX.Web.UI;

public partial class Page_WZ201520 : PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void enableBtn_OnClick(object sender, EventArgs e)
    {
        WZSetupMaint graph = PXGraph.CreateInstance<WZSetupMaint>();
        graph.enableWizards.Press();
        string url = ResolveUrl(PXUrl.MainPagePath);
        Controls.Add(new LiteralControl(@"<script  type='text/javascript'>try { window.top.location.href='" + url + "'; } catch (ex) {}</script>\n")); 
    }

    protected void disableBtn_OnClick(object sender, EventArgs e)
    {
        WZSetupMaint graph = PXGraph.CreateInstance<WZSetupMaint>();
        graph.disableWizards.Press();
        string url = ResolveUrl(PXUrl.MainPagePath);
        Controls.Add(new LiteralControl(@"<script  type='text/javascript'>try { window.top.location.href='" + url + "'; } catch (ex) {}</script>\n")); 
    }
}

#line default
#line hidden
