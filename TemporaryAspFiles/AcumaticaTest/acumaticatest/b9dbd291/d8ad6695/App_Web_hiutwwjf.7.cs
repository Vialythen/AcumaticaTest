#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201005.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A66BFCCE302706C3C6C88EA8BDB9141DF9F6634"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM201005.aspx.cs"
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Page_SM202000 : PX.Web.UI.PXPage
{
	public void Page_Load(object sender, EventArgs e)
	{
		if (PX.Data.Access.ActiveDirectoryProvider.Instance == PX.Data.Access.ActiveDirectoryProvider.Empty) 
			tab.Items["ad"].Visible = false;
	}
}


#line default
#line hidden
