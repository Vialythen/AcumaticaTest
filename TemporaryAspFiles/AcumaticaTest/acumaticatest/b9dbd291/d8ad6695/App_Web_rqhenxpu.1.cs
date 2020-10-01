#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CA\CA304000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A2AA513A9ACD62E3A7E056F14D3B205B19A06238"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CA\CA304000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_CA304000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if (this.Master.DocumentsGrid != null)
			this.Master.SetDocumentTemplate(docsTemplate.Columns[0].CellTemplate);
	}
}


#line default
#line hidden
