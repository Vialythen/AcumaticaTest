#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201040.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88F0A28429759140F0399C01CED6132DEB24387F"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201040.aspx.cs"
using System;
using System.Web;
using PX.SM;
using PX.Web.Customization;
using PX.Web.UI;

public partial class Pages_AU_AU201040 : PX.Web.UI.PXPage
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        this.Master.FindControl("usrCaption").Visible = false;
    }

    protected override void CreateChildControls()
    {
        base.CreateChildControls();
        PXDynamicFormGenerator.CreateChildControls(ds.DataGraph, this.FormPreview);
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
        AUWorkflowFormsMaint graph = this.ds.DataGraph as AUWorkflowFormsMaint;
        if (graph != null)
        {
            var fields = graph.GetFields();
            e.Result = string.Join(";", fields);
        }
    }
}


#line default
#line hidden
