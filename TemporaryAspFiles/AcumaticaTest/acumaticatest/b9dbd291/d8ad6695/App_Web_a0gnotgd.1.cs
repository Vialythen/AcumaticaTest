#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\FS\Calendars\MultiEmpDispatch\FS300300.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D2B22EC785A3E41B3B9CEE50AD9F84CDB887ED7"

#line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Pages\FS\Calendars\MultiEmpDispatch\FS300300.aspx.cs"
using PX.Objects.FS;
using PX.Common;
using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

public partial class Page_FS300300 : PX.Web.UI.PXPage
{
    public String applicationName;
    public String pageUrl;
    public String RefNbr;
    public String CustomerID;
    public String appointmentBodyTemplate;
    public String toolTipTemplateAppointment;
    public String toolTipTemplateServiceOrder;
    public String startDate;
    public String SMEquipmentID;
    public String AppSource;

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

		DateTime? startDateBridge;
        var date = PXContext.GetBusinessDate();
        
        startDateBridge = (date != null) ? date : PXTimeZoneInfo.Now;

        // Date
        try
        {
            if (!String.IsNullOrEmpty(Request.QueryString["Date"]))
            {
                startDateBridge = Convert.ToDateTime(Request.QueryString["Date"]);
            }
        }
        catch (Exception)
        {
        }

        startDate = ((DateTime)startDateBridge).ToString("MM/dd/yyyy h:mm:ss tt", new CultureInfo("en-US"));
        
        // Filter By RefNbr
        RefNbr = Request.QueryString["RefNbr"];

        // External CustomerID
        CustomerID = Request.QueryString["CustomerID"];

        // External SMEquipmentID
        SMEquipmentID = Request.QueryString["SMEquipmentID"];

        // Focus unassigned Appointment Tab
        AppSource = Request.QueryString["AppSource"];

        // Load Appointment's Body to be used in index.aspx
        StreamReader streamReader = new StreamReader(Server.MapPath("../../Shared/templates/EventTemplate.html"));
        appointmentBodyTemplate = streamReader.ReadToEnd();
        streamReader.Close();

        // Load Appointment's ToolTip to be used in index.aspx
        streamReader = new StreamReader(Server.MapPath("../../Shared/templates/TooltipAppointment.html"));
        toolTipTemplateAppointment = streamReader.ReadToEnd();
        streamReader.Close();
        
        // Load Service Order's ToolTip to be used in index.aspx
        streamReader = new StreamReader(Server.MapPath("../../Shared/templates/TooltipServiceOrder.html"));
        toolTipTemplateServiceOrder = streamReader.ReadToEnd();
        streamReader.Close(); 
    }

}

#line default
#line hidden
