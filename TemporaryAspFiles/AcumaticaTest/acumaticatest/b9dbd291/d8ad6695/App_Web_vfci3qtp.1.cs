#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM302050.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73CD0D92216DA5A51EDB286A0E7F9E6DB9EC56F9"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM302050.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;

public partial class Page_SM302050 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void grid_EditorsCreated(object sender, EventArgs e)
    {
        var grid = sender as PXGrid;
        if (grid != null)
        {
            var de = grid.PrimaryLevel.GetStandardEditor(GridStandardEditor.Date) as PXDateTimeEdit;
            if (de != null)
            {
                de.ShowRelativeDates = true;
            }
        }
    }
}

#line default
#line hidden
