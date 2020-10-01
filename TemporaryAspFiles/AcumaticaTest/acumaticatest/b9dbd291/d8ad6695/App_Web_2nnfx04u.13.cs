#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU204500.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1352EF8CF750069E8FB9E31AA15F18CB9E1DB5D"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU204500.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;

public partial class Page_AU204500 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	    this.Master.FindControl("usrCaption").Visible = false;
		lblCaption.InnerText = PXMessages.LocalizeNoPrefix(PX.AscxControlsMessages.Messages.CustomFilesCaption);
	}
}


#line default
#line hidden
