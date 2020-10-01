#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AR\AR505500.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9AFF9D02405410590C0173DD07B4F876B36537C"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AR\AR505500.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Common;

public partial class Page_AR505500 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if(!this.IsPostBack)
			PXContext.Session.PageInfo[PXUrl.ToAbsoluteUrl(Request.Path)] = null;
	}
}


#line default
#line hidden
