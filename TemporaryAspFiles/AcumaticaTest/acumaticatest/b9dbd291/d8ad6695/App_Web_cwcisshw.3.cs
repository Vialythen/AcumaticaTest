#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AR\AR304000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99C3BA4D85173FA70A4780073B110C10BBF89ED8"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AR\AR304000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_AR304000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if (this.Master.DocumentsGrid != null)
			this.Master.SetDocumentTemplate(docsTemplate.Columns[0].CellTemplate);
	}
}


#line default
#line hidden
