#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\ExternalResource\ExternalResource.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39485DAE50C6600120AA0511F5E8A858CE8071E2"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\ExternalResource\ExternalResource.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Data;
using PX.OAuthClient;

public partial class ExternalResource_ExternalResource : PX.Web.UI.PXPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        ((IPXMasterPage)this.Master).CustomizationAvailable = false;
        ((IPXMasterPage)this.Master).WebServicesAvailable = false;
        ((IPXMasterPage)this.Master).AuditHistoryAvailable = false;
        OnPreInit(e);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        var id = Request.QueryString["id"];
        Guid resourceId;
        if (id == null || !Guid.TryParse(id, out resourceId))
            throw new InvalidOperationException(string.Format("Resource with id {0} not found", id));
        var graph = (ResourceMaint)this.DefaultDataSource.DataGraph;
        IPXMasterPage master = Page.Master as IPXMasterPage;

        if (master != null && graph != null && graph.Resources.Current != null)
        {
            master.ScreenTitle = graph.Resources.Current.SitemapTitle ?? graph.Resources.Current.ResourceName;
        }
        var tokenResourceAndApplication = graph.GetAuthTokenResourceAndApplication(resourceId);
        if (tokenResourceAndApplication == null)
            throw new InvalidOperationException(string.Format("Resource with id {0} not found", id));
        resourceHtml.Text = graph.ResourceHtml(tokenResourceAndApplication.Item1, tokenResourceAndApplication.Item2,
            tokenResourceAndApplication.Item3);
    }
}

#line default
#line hidden
