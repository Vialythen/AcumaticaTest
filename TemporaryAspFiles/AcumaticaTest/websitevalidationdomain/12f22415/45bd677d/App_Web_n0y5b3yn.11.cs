#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\Customization\AcumaticaTest\AcumaticaTestValidation\AcumaticaTestWebsite\MasterPages\FormTab.master.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44E9B3C6EF125CF070250F9213DB30B41E3C60B0"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\Customization\AcumaticaTest\AcumaticaTestValidation\AcumaticaTestWebsite\MasterPages\FormTab.master.cs"
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.UI;
using PX.Common;

public partial class Master_FormTab : PX.Web.UI.BaseMasterPage
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
		base.InsertDocumentsFrame(this.form1);
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
