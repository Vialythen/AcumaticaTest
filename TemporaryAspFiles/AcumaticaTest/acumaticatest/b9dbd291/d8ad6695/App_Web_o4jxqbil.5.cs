#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\AppSetup.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EF0DB5490F0DDB6EC1719BE9043C436F7D90EA74"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\AppSetup.aspx.cs"
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Pages_Ledger : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		this.Master.ScreenID = "11.00.00.00";
		this.Master.ScreenTitle = "#AS000000";
	}

	/// <summary>
	/// Sets the navigation links images.
	/// </summary>
	protected void siteLinks_ItemDataBound(object sender, DataListItemEventArgs e)
	{
		INavigateUIData dataItem = e.Item.DataItem as INavigateUIData;
		if (dataItem != null && !string.IsNullOrEmpty(dataItem.Description))
		{
			string descr = dataItem.Description;
			Image image = (Image)e.Item.FindControl("linkIm");
			image.ImageUrl = this.ResolveUrl/**/(descr.Split('|')[0]);
		}
	}
}


#line default
#line hidden
