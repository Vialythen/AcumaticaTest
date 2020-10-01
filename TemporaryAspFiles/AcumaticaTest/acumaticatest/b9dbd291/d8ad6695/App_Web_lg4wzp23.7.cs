#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Wiki\Feedback.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F462223FDCB2EB0534424041E3CC9D14AAD9A26A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Wiki\Feedback.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Web.UI;

public partial class Pages_Feedback : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.FindControl("usrCaption").Visible = false;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		this.Master.PopupWidth = 650;
		this.Master.PopupHeight = 350;
		
		PXLabel label = this.formview.FindControl("PXLabel") as PXLabel;
		if (label != null)
		{
			label.Text = PXSiteMap.IsPortal ? "Any comments and suggestions you would like to submit:" : "Other user comments and suggestions:";
		}
	}
}

#line default
#line hidden
