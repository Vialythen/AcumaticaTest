#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Wiki\Show.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85765CA43D674DB7381A673E2DA3222A1009DE39"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Wiki\Show.aspx.cs"
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI.WebControls;
using PX.Common;
using PX.Data;
using PX.SM;
using PX.Web.Controls.Wiki;
using PX.Web.UI;

public partial class Page_Show : PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		ShowRouter.Instance.TryRedirect(Request, Context);
	}
}


#line default
#line hidden
