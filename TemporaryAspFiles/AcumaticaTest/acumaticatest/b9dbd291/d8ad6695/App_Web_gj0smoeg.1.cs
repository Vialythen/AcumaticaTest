#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM206506.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "333DD450C4EF5622C1A227999465DA904436412A"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM206506.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Page_SM206506 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Control control = this.Master.FindControl("usrCaption");
        if (control != null)
        {
            control.Visible = false;
        }
        this.Master.PopupHeight = 350;
        this.Master.PopupWidth = 500;
    }
}

#line default
#line hidden
