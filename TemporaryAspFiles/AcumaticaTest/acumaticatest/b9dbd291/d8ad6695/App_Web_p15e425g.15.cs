#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204003.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F035769B741773E38A481594AF5CF5F22BBA061D"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\SM\SM204003.aspx.cs"
using PX.SM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_SM_SM204003 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
	protected void edBody_BeforePreview(object src, PX.Web.UI.PXRichTextEdit.BeforePreviewArgs args)
	{
		var notification = (DefaultDataSource.DataGraph as SMNotificationMaint).Notifications.Current;
		if (null != notification)
		{
			var info = PX.Api.ScreenUtils.GetScreenInfo(notification.ScreenID);
			if (info != null)
			{
				args.GraphName = info.GraphName;
				args.ViewName = info.PrimaryView;
			}
		}
	}
	protected void edBody_BeforeFieldPreview(object src, PX.Web.UI.PXRichTextEdit.BeforeFieldPreviewArgs args)
	{
		if (args.Type == typeof(PX.SM.Users) && args.FieldName == "UserList.Password")
			args.Value = "*******";
	}
}

#line default
#line hidden
