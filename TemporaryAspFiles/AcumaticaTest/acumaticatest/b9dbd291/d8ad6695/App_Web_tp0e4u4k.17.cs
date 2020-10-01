#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\Menu.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108A275FDF01D2DE2AB5D72350411BC20DF0C38E"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Api\Menu.aspx.cs"
using System;
using PX.Api;

public partial class Api_Menu : PX.Web.UI.PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{

//		CheckPaused.Checked = TraceStorage.Paused;
	}
	protected void CheckPaused_CheckedChanged(object sender, EventArgs e)
	{
		//TraceStorage.Paused = !TraceStorage.Paused;
		//CheckPaused.Checked = TraceStorage.Paused;

	}
	protected void ButtonClearTrace_Click(object sender, EventArgs e)
	{
		//TraceStorage.ClearLog();
	}
	protected void ButtonClearCaches_Click(object sender, EventArgs e)
	{
		//TraceStorage.ClearCaches();
	}
}


#line default
#line hidden
