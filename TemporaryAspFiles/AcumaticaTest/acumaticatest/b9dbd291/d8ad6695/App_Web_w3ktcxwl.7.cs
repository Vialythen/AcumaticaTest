#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9E3DE7BDC0CE6B4F9BE0DDE60E20D9BD17C171DF"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP301000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using PX.Objects.AP;

public partial class Page_AP301000 : PX.Web.UI.PXPage
{
    protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.PopupHeight = 700;
		this.Master.PopupWidth = 970;
		if (this.Master.DocumentsGrid != null)
			this.Master.SetDocumentTemplate(docsTemplate.Columns[0].CellTemplate);
    }
}


#line default
#line hidden
