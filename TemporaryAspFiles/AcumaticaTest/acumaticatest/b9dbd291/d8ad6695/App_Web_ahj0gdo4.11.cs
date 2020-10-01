#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201030.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B14062E7088F81669FFFF5DA43A66C122CA7B7B"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AU\AU201030.aspx.cs"
using System;
using System.Web;
using PX.SM;
using PX.Web.Controls;
using PX.Web.Customization;
using PX.Web.UI;

public partial class Page_AU201030 : PX.Web.UI.PXPage
{
	protected void Page_PreInit(object sender, EventArgs e)
    {
		ProjectBrowserMaint.InitSessionFromQueryString(HttpContext.Current);       
	}

	protected void Page_Init(object sender, EventArgs e)
	{
        this.Master.FindControl("usrCaption").Visible = false;
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
        AUWorkflowMaint graph = this.ds.DataGraph as AUWorkflowMaint;
        if (graph != null)
        {
            var formulaEdit = sender as PXFormulaCombo;
            var fields = graph.GetFieldsAndParams(formulaEdit!= null && formulaEdit.Parameters.Contains("UseParentAction"));
            e.Result = string.Join(";", fields);
        }
    }
}


#line default
#line hidden
