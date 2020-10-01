#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\MasterPages\ClearWorkspace.master.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1E77D1431E4A072C1AE1EEE986B8B856F6C4DEB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\MasterPages\ClearWorkspace.master.cs"
using System;
using PX.Common;
public partial class Master_ClearWorkspace : PX.Web.UI.BaseMasterPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!PX.Translation.ResourceCollectingManager.IsStringCollecting)
		{
			Response.TryAddHeader("cache-control", "no-store, private");
		}
	}

	#region Public properties
	/// <summary>
	/// Gets or sets the screen title string.
	/// </summary>
	public string ScreenTitle
	{
		get { return Page.Title; }
		set { Page.Title = value; }
	}
	#endregion
}


#line default
#line hidden
