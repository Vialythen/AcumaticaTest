#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\MasterPages\FormView.master.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8AB675A1F4AA8088CC1E572E33C5058C546A0B2"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\MasterPages\FormView.master.cs"
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using System.Collections.Generic;
using PX.Common;

public partial class Master_FormView : PX.Web.UI.BaseMasterPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!PX.Translation.ResourceCollectingManager.IsStringCollecting)
		{
			Response.TryAddHeader("cache-control", "no-store, private");
		}
	}

	// We'll need this code in case we use ASP.NET standard localization
	protected void Page_Init(object sender, EventArgs e)
	{
		//if (PXDataSource.RedirectHelper.IsPopupPage(Page)) statusBar.Visible = false;
	}

	#region Public properties
	/// <summary>
	/// Gets or sets the screen title string.
	/// </summary>
	public string ScreenTitle
	{
		get { return this.usrCaption.ScreenTitle; }
		set { this.usrCaption.ScreenTitle = value; }
	}

	/// <summary>
	/// Gets or sets the screen ID text.
	/// </summary>
	public string ScreenID
	{
		get { return this.usrCaption.ScreenID; }
		set { this.usrCaption.ScreenID = value; }
	}

	/// <summary>
	/// Gets or sets the screen image url.
	/// </summary>
	public string ScreenImage
	{
		get { return this.usrCaption.ScreenImage; }
		set { this.usrCaption.ScreenImage = value; }
	}

	/// <summary>
	/// Gets or sets the favorite maintenance availability
	/// </summary>
	public bool FavoriteAvailable
	{
		get { return this.usrCaption.FavoriteAvailable; }
		set { this.usrCaption.FavoriteAvailable = value; }
	}
	
	#endregion
}


#line default
#line hidden
