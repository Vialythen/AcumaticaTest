#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS205020.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146C36F70732E46E87EC2154D135B74591DDF572"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS205020.aspx.cs"
using PX.Data;
using PX.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_CS205020 : PX.Web.UI.PXPage
{
    protected override void OnInitComplete(EventArgs e)
    {
        base.OnInitComplete(e);
        form.ControlsCreating += Form_ControlsCreating;
        string screen = Request.QueryString["forscreen"];
        var cache = ds.DataGraph.Views["SelectedScreen"].Cache;
        var scrn = cache.Current as PX.Data.AttribParams;

        if (scrn != null)
        {
            if (!string.IsNullOrEmpty(screen))
            {
                cache.SetValue<PX.Data.AttribParams.screenID>(cache.Current, screen);
                Session[sessionKey] = screen;
            }
            else if (string.IsNullOrEmpty(scrn.ScreenID))
            {
                cache.SetValue<PX.Data.AttribParams.screenID>(cache.Current, Session[sessionKey]);
            }
        }
    }
    const string sessionKey = "LastAttribScreen";
    private void Form_ControlsCreating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var cache = ds.DataGraph.Views["SelectedScreen"].Cache;
        var scrn = cache.Current as PX.Data.AttribParams;
        if (scrn.ScreenID != null || PXGraph.GeneratorIsActive)
        {
            string screen = PXGraph.GeneratorIsActive ? "00000000" : scrn.ScreenID.Replace(".", "");
            var controls = new List<Control>();
            var panel = new PXAttribPanel() { ID = "panel" };
            panel.Controls.Add(PXAttribPanel.CreateDesignAttribTable(screen, controls, this));
             form.TemplateContainer.Controls.Add(panel);

			var node = PXSiteMap.Provider.FindSiteMapNodeByScreenID(screen);
			if (null != node ) panel.ScreenTitle = node.Title;
		}
    }
}


#line default
#line hidden
