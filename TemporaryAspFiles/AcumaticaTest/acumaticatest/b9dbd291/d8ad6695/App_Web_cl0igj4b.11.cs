#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F9D2AA5BFB253DA03F494D98AC609414AD9E754D"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\GL\GL301000.aspx.cs"
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.UI;
using System.Collections;

public partial class Page_GL301000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		//object obj2 = this.LoadPageStateFromPersistenceMedium();
		//IDictionary first = null;
		//Pair second = null;
		//Pair pair2 = obj2 as Pair;
		//if (obj2 != null)
		//{
		//    first = pair2.First as IDictionary;
		//    second = pair2.Second as Pair;
		//}
		//if (first != null)
		//{
		//    ArrayList ar = (ArrayList)first["__ControlsRequirePostBackKey__"];
		//}
		if (this.Master.DocumentsGrid != null)
			this.Master.SetDocumentTemplate(docsTemplate.Columns[0].CellTemplate);
	}
}


#line default
#line hidden
