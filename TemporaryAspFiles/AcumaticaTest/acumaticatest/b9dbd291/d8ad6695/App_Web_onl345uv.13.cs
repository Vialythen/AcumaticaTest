#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894438CCE3D61AB63E3CB60EB7E09AA567EFC0B3"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201010.aspx.cs"
using System;
using System.Linq;
using System.Web;
using PX.SM;
using PX.Web.Customization;
using PX.Web.UI;

public partial class Page_AU201010 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
        this.Master.FindControl("usrCaption").Visible = false;
	    ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);
    }

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

    protected void edValue_RootFieldsNeeded(object sender, PXCallBackEventArgs e)
    {
        var graph = this.ds.DataGraph as AUScreenConditionMaint;
        if (graph != null)
        {
            var fields = graph.GetFields();
            if (fields == null)
                return;
            e.Result = string.Join(";", fields.Select(it=>it.Item1).Union(graph.GetParameters()));
        }
    }
}


#line default
#line hidden
