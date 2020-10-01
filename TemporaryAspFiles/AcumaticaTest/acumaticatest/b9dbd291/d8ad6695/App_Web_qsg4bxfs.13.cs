#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL102000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D879CE068D108993BB182761A50ADDA1239B27E5"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL102000.aspx.cs"
using System;
using PX.Web.UI;

public partial class Page_GL102000 : PXPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PXGroupBox gb = (PXGroupBox)form.FindControl("gbCOAOrder");
		((PXRadioButton)gb.FindControl("gbCOAOrder_op0")).Text = PX.Objects.GL.Messages.COAOrderOp0;
		((PXRadioButton)gb.FindControl("gbCOAOrder_op1")).Text = PX.Objects.GL.Messages.COAOrderOp1;
		((PXRadioButton)gb.FindControl("gbCOAOrder_op2")).Text = PX.Objects.GL.Messages.COAOrderOp2;
		((PXRadioButton)gb.FindControl("gbCOAOrder_op3")).Text = PX.Objects.GL.Messages.COAOrderOp3;
		((PXRadioButton)gb.FindControl("gb_COAOrder_op128")).Text = PX.Objects.GL.Messages.COAOrderOp128;
	}
}


#line default
#line hidden
