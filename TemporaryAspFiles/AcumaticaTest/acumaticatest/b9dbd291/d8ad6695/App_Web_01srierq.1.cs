#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204580.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7E62C2C080892CB031CE965CE197E21C4BFEC0F1"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204580.aspx.cs"
using System;
using System.Web;
using PX.Data;
using PX.Web.Customization;
using PX.Web.UI;

[Customization.CstDesignMode(Disabled = true)]
public partial class Pages_SM_SM204580 : PXPage
{
	protected override void OnInit(EventArgs e)
	{

		this.Master.FindControl("usrCaption").Visible = false;
		ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);


		((IPXMasterPage)this.Master).CustomizationAvailable = false;
		base.OnInit(e);
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		
	}

	/// <summary>
	/// The page PreRenderComplete event handler.
	/// </summary>
	protected override void OnPreRenderComplete(EventArgs e)
	{
		string query = ProjectBrowserMaint.ContextCodeFile;
		if (!string.IsNullOrEmpty(query))
		{
			this.ClientScript.RegisterStartupScript(this.GetType(), "query", 
				string.Format("\nvar __queryString = '{0}={1}'; ", "CodeFile", query.Replace('#', '*')), true);
		}
		base.OnPreRenderComplete(e);
	}

	public string GetScriptName(string rname)
	{
		string resource = "PX.Web.Customization.Controls.cseditor." + rname;
		string url = ClientScript.GetWebResourceUrl(typeof(Customization.WebsiteEntryPoints), resource);
		url = url.Replace(".axd?", ".axd?file=" + rname + "&");
		return HttpUtility.HtmlAttributeEncode(url);
	}

	//public string ProjectName
	//{
	//    get { return CstSession.Current.IfNotNull(s => s.GetProjectName()); }

	//}
}


#line default
#line hidden
