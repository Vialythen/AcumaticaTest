#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR202000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54EA65415F9D7725DBA092263F1FD90096BA0126"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR202000.aspx.cs"
using System;
using PX.Objects.CR;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_CR202000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}
	protected void edProjectTaskID_EditRecord(object sender, PX.Web.UI.PXNavigateEventArgs e)
	{
		var campaignMaint = this.ds.DataGraph as CampaignMaint;
		if (campaignMaint != null)
		{
			var currentCampaign = this.ds.DataGraph.Views[this.ds.DataGraph.PrimaryView].Cache.Current as CRCampaign;
			if (currentCampaign.ProjectID.HasValue && !currentCampaign.ProjectTaskID.HasValue)
			{
				{
					try
					{
						campaignMaint.addNewProjectTask.Press();
					}
					catch (PX.Data.PXRedirectRequiredException e1)
					{
						PX.Web.UI.PXBaseDataSource ds = this.ds as PX.Web.UI.PXBaseDataSource;
						PX.Web.UI.PXBaseDataSource.RedirectHelper helper = new PX.Web.UI.PXBaseDataSource.RedirectHelper(ds);
						helper.TryRedirect(e1);
					}
				}
			}
		}
	}
}


#line default
#line hidden
