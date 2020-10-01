#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP304000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F4F27D681DB4FB808C93968C62D198A3B7EF0B1"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\AP\AP304000.aspx.cs"
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

public partial class Page_AP304000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		if (this.Master.DocumentsGrid != null)
			this.Master.SetDocumentTemplate(docsTemplate.Columns[0].CellTemplate);
	}
}


#line default
#line hidden
