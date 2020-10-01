#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Controls\ProcessingDialogs.ascx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613A1DE27C616383EDA4F8F2248372036A4DE4CA"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Controls\ProcessingDialogs.ascx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Web.UI;

public partial class Controls_ProcessingDialogs : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    private bool _isInitProcessing;
    void InitProcessing()
    {
        if (_isInitProcessing)
            return;

        _isInitProcessing = true;


        var p = (PXPage)this.Page;

        if (p.DefaultDataSource == null)
            return;

        var graph = p.DefaultDataSource.DataGraph;
        if (!graph.IsProcessing || PXGraph.ProxyIsActive)
            return;

        var ds = p.DefaultDataSource;
        foreach (string command in ds.GetCommandsForProcessingGrid())
        {
            this.gridDetails.ActionBar.CustomItems.Add(new PXToolBarButton { CommandSourceID = ds.ID, CommandName = command });
        }


        

       //ViewProcessingResults.AutoRepaint = true;
       //gridDetails.AutoRepaint = true;
       //PanelProgress.LoadOnDemand = false;
       //PanelLongRunDetails.LoadOnDemand = false;

       var pview = graph.Views.Where(_ => _.Value is IPXProcessingView).ToDictionary(_ => _.Key);

        var list = ControlHelper.GetDataControls(this.Page, null);
        foreach (var control in list)
        {
            if (!(control is PXGrid))
                continue;
            if (control == gridDetails)
                continue;
            var srcGrid = (PXGrid)control;
            //var select = graph.Views[srcGrid.DataMember];
            if (pview.ContainsKey(srcGrid.DataMember))
            {
                this.gridDetails.TemplateEditors.Clear();
                foreach (var srcGridTemplateEditor in srcGrid.TemplateEditors)
                {
                    this.gridDetails.TemplateEditors.Add(srcGridTemplateEditor.Key, srcGridTemplateEditor.Value);
                }
                foreach (PXGridColumn src in srcGrid.Columns.AspxColumns)
                {
                    if (src.DataField == "Selected")
                        continue;
                    var dest = this.gridDetails.Columns[src.DataField];

                    if (dest == null)
                    {
                        dest = new PXGridColumn
                        {
                            DataField = src.DataField
                        };
                        dest.CopyFrom(src);
                        dest.ViewName = src.ViewName;
                        this.gridDetails.Columns.Add(dest);
                    }
                    else
                    {
                        dest.CopyFrom(src);
                        dest.ViewName = src.ViewName;
                    }

                    dest.Width = src.Width;




                }

                break;
            }
        }

    }

    protected void gridDetails_OnBeforeGenerateColumns(object sender, EventArgs e)
    {
        InitProcessing();
    }
}

#line default
#line hidden
