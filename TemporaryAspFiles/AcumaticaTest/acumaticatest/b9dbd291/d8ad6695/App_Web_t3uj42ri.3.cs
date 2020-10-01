#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E02622FE0668CE65470670A68D3A7A73D922378"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\CR\CR301000.aspx.cs"
using System;
using PX.Data;
using PX.Objects.CR;

public partial class Page_CR301000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		Master.PopupHeight = 700;
		Master.PopupWidth = 900;
	}

	protected void edRefContactID_EditRecord(object sender, PX.Web.UI.PXNavigateEventArgs e)
	{
		LeadMaint leadMaint = this.ds.DataGraph as LeadMaint;

		var selector = sender as PX.Web.UI.PXSelector;
		object value = null;

		if (selector != null)
			value = selector.Value;

		try
		{
			var graph = PXGraph.CreateInstance<ContactMaint>();

			if (value != null)
			{
				Contact contact = PXSelect<Contact, Where<Contact.contactID, Equal<Required<CRLead.refContactID>>>>.SelectSingleBound(graph, null, value);

				graph.Contact.Current = contact;
			}

			PXRedirectHelper.TryRedirect(graph);
		}
		catch (PX.Data.PXRedirectRequiredException e1)
		{
			PX.Web.UI.PXBaseDataSource ds = this.ds as PX.Web.UI.PXBaseDataSource;
			PX.Web.UI.PXBaseDataSource.RedirectHelper helper = new PX.Web.UI.PXBaseDataSource.RedirectHelper(ds);
			helper.TryRedirect(e1);
		}
	}
}


#line default
#line hidden
