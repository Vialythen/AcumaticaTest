#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204590.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840E842122C9B329022BF87D2DA77A6C5C794A55"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204590.aspx.cs"
using System;
using System.Web;
using PX.Data;
using PX.Web.Customization;
using PX.Web.UI;

[Customization.CstDesignMode(Disabled = true)]
public partial class Pages_SM_SM204590 : PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		((IPXMasterPage)this.Master).CustomizationAvailable = false;
		this.Master.FindControl("usrCaption").Visible = false;
		ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);

		//string screenID = this.Request.QueryString["EditScreenID"];
		//if (!string.IsNullOrEmpty(screenID)) ProjectBrowserMaint.ContextScreenID = screenID;
	}

	protected void Page_Load(object sender, EventArgs e)
	{

	}

	public string GetScriptName(string rname)
	{
		string resource = "PX.Web.Customization.Controls.cseditor." + rname;
		string url = ClientScript.GetWebResourceUrl(typeof(Customization.WebsiteEntryPoints), resource);
		url = url.Replace(".axd?", ".axd?file=" + rname + "&");
		return HttpUtility.HtmlAttributeEncode(url);
		//			return VirtualPathUtility.GetFileName(url);

	}

	protected override void OnPreRenderComplete(EventArgs e)
	{
		string query = ProjectBrowserMaint.ContextScreenID;
		if (!string.IsNullOrEmpty(query))
		{
			this.ClientScript.RegisterStartupScript(this.GetType(), "query",
				string.Format("\nvar __queryString = '{0}={1}'; ", "EditScreenID", query), true);
		}
		base.OnPreRenderComplete(e);
	}
}


#line default
#line hidden
