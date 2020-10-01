#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS209010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EEDD407AE5F25ABD8801865F97128BBAD412B2D8"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CS\CS209010.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_CS209010 : PX.Web.UI.PXPage
{
	protected void grd_EditorsCreated_RelativeDates(object sender, EventArgs e)
	{
		PXGrid grid = sender as PXGrid;
		if (grid != null)
		{
			PXDateTimeEdit de = grid.PrimaryLevel.GetStandardEditor(GridStandardEditor.Date) as PXDateTimeEdit;
			if (de != null)
			{
				de.ShowRelativeDates = true;
			}
		}
	}
}


#line default
#line hidden
