#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\HS\LoggedIn.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE84380EAE7270295762CE66DE3460F38F7EFF28"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\HS\LoggedIn.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.DataSync.HubSpot;
using PX.Api;
using PX.Data;

public partial class Pages_HS_LoggedIn : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Request.QueryString["provider"]) || string.IsNullOrEmpty(Request.QueryString["code"])) return;
		var providerName = Request.QueryString["provider"];
		var code = Request.QueryString["code"];
		try
		{
			HubSpotProvider.OnOAuthCodeReceived(providerName, code);
			ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
			string script = "this.window.opener.location=this.window.opener.location;this.window.close('Default.aspx');";
			ClientScript.RegisterClientScriptBlock(typeof(string), "refreshParent", script, true);
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
		finally
		{
			Response.Flush();
		}
	}
}

#line default
#line hidden
