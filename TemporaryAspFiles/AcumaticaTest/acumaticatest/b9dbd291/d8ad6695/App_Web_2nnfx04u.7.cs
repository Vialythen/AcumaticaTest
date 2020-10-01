#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU203002.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3A8F05A1CC01C95B6E36C20033F725A760E1B330"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU203002.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.Customization;
using PX.Web.UI;

public partial class  Page_AU203002 : PX.Web.UI.PXPage
{
	protected override void OnInit(EventArgs e)
	{

		this.Master.FindControl("usrCaption").Visible = false;
		ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);
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
		string query = ProjectBrowserMaint.ContextTableName;
		if (!string.IsNullOrEmpty(query))
		{
			this.ClientScript.RegisterStartupScript(this.GetType(), "query",
				string.Format("\nvar __queryString = '{0}={1}'; ", "TableName", query.Replace('+', '*')), true);
		}
		base.OnPreRenderComplete(e);
	}
}


#line default
#line hidden
