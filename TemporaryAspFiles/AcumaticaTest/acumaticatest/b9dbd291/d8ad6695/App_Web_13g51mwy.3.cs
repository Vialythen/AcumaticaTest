#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR306000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51C9C0EF0C121595D831319BD2220584ED7290C0"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR306000.aspx.cs"
using System;
using PX.Objects.CR;


public partial class Page_CR306000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.PopupHeight = 700;
		this.Master.PopupWidth = 900;
	}

    protected void edContactID_EditRecord(object sender, PX.Web.UI.PXNavigateEventArgs e)
    {
        CRCaseMaint casemaint = this.ds.DataGraph as CRCaseMaint;
        if (casemaint != null)
        {
            CRCase currentcase = this.ds.DataGraph.Views[this.ds.DataGraph.PrimaryView].Cache.Current as CRCase;
            if (currentcase.ContactID == null && currentcase.CustomerID != null)
            {
                {
                    try
                    {
                        casemaint.addNewContact.Press();
                    }
                    catch (PX.Data.PXRedirectRequiredException e1)
                    {
                        PX.Web.UI.PXBaseDataSource ds = this.ds as PX.Web.UI.PXBaseDataSource;
                        PX.Web.UI.PXBaseDataSource.RedirectHelper helper = new PX.Web.UI.PXBaseDataSource.RedirectHelper(ds);
                        helper.TryRedirect(e1);
                    }
                }
            }
        }
    }
}


#line default
#line hidden
