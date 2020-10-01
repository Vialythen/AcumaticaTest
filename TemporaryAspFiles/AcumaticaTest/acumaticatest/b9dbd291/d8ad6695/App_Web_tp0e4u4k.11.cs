#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\ProcessPages.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB19D25B07A54650BE5694DFFC91558BE2162B5E"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\ProcessPages.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customization;

public partial class Api_ProcessPages : System.Web.UI.Page
{
	public override void ProcessRequest(HttpContext context)
	{
		var r = new PXResponse { 
			HtmlLog =
				m => { 
					context.Response.Write(m);
					context.Response.Flush();
				
				} };

		PXResponse.Current = r;
		//PXAspxCleanup.Run3();
		PXReportValidator.Run();

		PXResponse.Current = null;


		//base.ProcessRequest(context);
	}

}


#line default
#line hidden
