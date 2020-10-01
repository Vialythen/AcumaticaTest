#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\WsdlHelp.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19779BFEE729C4F4959E9AB09249D3EDABA323DE"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\WsdlHelp.aspx.cs"
using System.Web;
using System.Web.UI;
using PX.Api.Soap.Screen;

public partial class Frames_WsdlHelp : Page
{
	public override void ProcessRequest(HttpContext context)
	{
		WsdlBuilder.ProcessHelpRequest(context);
	}
}


#line default
#line hidden
