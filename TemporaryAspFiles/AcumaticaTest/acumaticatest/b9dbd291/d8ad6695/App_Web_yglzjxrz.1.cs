#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\FS\Calendars\CalendarPreferences\FS100200.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "822A20EDE65995FFB4EFDC0CA4DA4B5D08022094"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\FS\Calendars\CalendarPreferences\FS100200.aspx.cs"
using System;
using System.IO;
using PX.Objects.FS;
using System.Collections.Generic;

public partial class Page_FS100200 : PX.Web.UI.PXPage
{
    public string applicationName;
    public string pageUrl;
    public string preferencesTemplate;

    protected void Page_Init(object sender, EventArgs e)
    {
        if (!Page.IsCallback)
        {
            var dict = SharedFunctions.GetCalendarMessages();
            this.ClientScript.RegisterClientScriptBlock(GetType(), "localeStrings", "var __localeStrings=" + Newtonsoft.Json.JsonConvert.SerializeObject(dict) + ";", true);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        applicationName = Request.ApplicationPath.TrimEnd('/');
        pageUrl = SharedFunctions.GetWebMethodPath(Request.Path);

        // Load Preference Template
        StreamReader streamReader = new StreamReader(Server.MapPath("../../Shared/templates/PreferencesTemplate.html"));
        preferencesTemplate = streamReader.ReadToEnd();
        streamReader.Close();
    }
}

#line default
#line hidden
