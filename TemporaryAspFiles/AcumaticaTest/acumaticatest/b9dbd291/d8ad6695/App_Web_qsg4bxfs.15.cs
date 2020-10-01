#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL506000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407BFCE0B2F0BB35B043E97C6C7BD91A4E3DB3FB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL506000.aspx.cs"
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Objects.GL.Reclassification.Common;

public partial class Page_GL506000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
        RegisterStyle("CssSplitting", null, null, true);
        RegisterStyle("CssNegativeAmount", null, Color.Red, true);
    }

    private void RegisterStyle(string name, Color? backColor, Color? foreColor, bool bold)
    {
        Style style = new Style();
        if (backColor != null) style.BackColor = backColor.Value;
        if (foreColor != null) style.ForeColor = foreColor.Value;
        style.Font.Bold = bold;
        Page.Header.StyleSheet.CreateStyleRule(style, this, "." + name);
    }

    protected void grid_OnRowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
    {
        GLTranForReclassification tran;

        PXResult record = e.Row.DataItem as PXResult;
        if (record != null)
        {
            tran = (GLTranForReclassification)record[typeof(GLTranForReclassification)];
        }
        else
        {
            tran = e.Row.DataItem as GLTranForReclassification;
        }

        if (tran == null)
            return;

        if (tran.IsSplitted || tran.IsSplitting)
        {
            e.Row.Style.CssClass = "CssSplitting";
        }
        else
        {
            e.Row.Style.Reset();
        }

        if (tran.CuryNewAmt < 0)
        {
            e.Row.Cells["CuryNewAmt"].Style.CssClass = "CssNegativeAmount";
        }
        else
        {
            e.Row.Cells["CuryNewAmt"].Style.Reset();
        }
    }
}


#line default
#line hidden
