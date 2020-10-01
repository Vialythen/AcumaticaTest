#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR306035.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61DA5DD6A0214B017DC49EFA95C58E65E9450FCB"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR306035.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data;
using PX.Data.Wiki.Parser;
using PX.Objects.CR;
using PX.SM;
using PX.Web.UI;
using PX.Web.Controls;


public partial class Page_CR306035 : PX.Web.UI.PXPage
{
	private int IsHasRedException()
    {
        CRSMEmailMaint graph = (CRSMEmailMaint)this.ds.DataGraph;
        if (graph.Email.Current == null)
        {
            return 2;
        }
        else if(String.IsNullOrEmpty(graph.Email.Current.Exception))
        {
            return 1;
        }
        return 0;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        PX.Web.UI.PXHtmlView Exception = (PX.Web.UI.PXHtmlView)this.frmViewMessage.FindControl("edRedException");
        if (IsHasRedException() == 1)
        {
            if (Exception != null)
                Exception.Hidden = true;            
        }        
    }
    
    protected void on_data_bound(object sender, EventArgs e)
    {
        PX.Web.UI.PXHtmlView Exception = (PX.Web.UI.PXHtmlView)this.frmViewMessage.FindControl("edRedException");
        if (IsHasRedException() == 1)
        {
            if (Exception != null)
                Exception.Hidden = true;
        }        
    }
}


#line default
#line hidden
