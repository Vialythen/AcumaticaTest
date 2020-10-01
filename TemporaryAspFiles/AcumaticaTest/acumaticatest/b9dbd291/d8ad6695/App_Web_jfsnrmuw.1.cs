#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN404000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33B80C0516AB6A14A05C33E50BC8BB416E0B5B34"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\IN\IN404000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.Objects.IN;
using PX.Web.UI;

public partial class Page_IN404000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.IsCallback)
		{
			PXLabel lbl = this.form.FindControl("lblNote1") as PXLabel;
			if (lbl != null)
				lbl.Text = Messages.EstimatedCosts;
		}
	}
}


#line default
#line hidden
