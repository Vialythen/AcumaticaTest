﻿#pragma checksum "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F0B811A16250E0C8A017D0CAE60DD877FF67537E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



public partial class Pages_ReportLauncher : System.Web.SessionState.IRequiresSessionState {
    
    
    #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    protected global::ASP.controls_pagetitle_ascx usrCaption;
    
    #line default
    #line hidden
    
    
    #line 14 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    protected global::PX.Web.UI.PXSoapDataSource ds;
    
    #line default
    #line hidden
    
    
    #line 18 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    protected global::PX.Web.UI.PXToolBar tlbReport;
    
    #line default
    #line hidden
    
    
    #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    protected global::PX.Web.UI.PXReportViewer viewer;
    
    #line default
    #line hidden
    
    
    #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    protected global::System.Web.UI.HtmlControls.HtmlForm form1;
    
    #line default
    #line hidden
    
    protected System.Web.Profile.DefaultProfile Profile {
        get {
            return ((System.Web.Profile.DefaultProfile)(this.Context.Profile));
        }
    }
    
    protected ASP.global_asax ApplicationInstance {
        get {
            return ((ASP.global_asax)(this.Context.ApplicationInstance));
        }
    }
}
namespace ASP {
    
    #line 330 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 326 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    using ASP;
    
    #line default
    #line hidden
    
    #line 340 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 343 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 339 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 342 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.HtmlControls;
    
    #line default
    #line hidden
    
    #line 14 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
    using PX.Web.UI;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
    #line default
    #line hidden
    
    #line 328 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.ComponentModel.DataAnnotations;
    
    #line default
    #line hidden
    
    #line 331 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 338 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Profile;
    
    #line default
    #line hidden
    
    #line 334 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Caching;
    
    #line default
    #line hidden
    
    #line 325 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 341 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 335 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.DynamicData;
    
    #line default
    #line hidden
    
    
    [System.Runtime.CompilerServices.CompilerGlobalScopeAttribute()]
    public class frames_reportlauncher_aspx : global::Pages_ReportLauncher, System.Web.IHttpHandler {
        
        private static System.Reflection.MethodInfo @__PageInspector_SetTraceDataMethod = global::ASP.frames_reportlauncher_aspx.@__PageInspector_LoadHelper("SetTraceData");
        
        private static System.Reflection.MethodInfo @__PageInspector_BeginRenderTracingMethod = global::ASP.frames_reportlauncher_aspx.@__PageInspector_LoadHelper("BeginRenderTracing");
        
        private static System.Reflection.MethodInfo @__PageInspector_EndRenderTracingMethod = global::ASP.frames_reportlauncher_aspx.@__PageInspector_LoadHelper("EndRenderTracing");
        
        private static bool @__initialized;
        
        private static object @__fileDependencies;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public frames_reportlauncher_aspx() {
            string[] dependencies;
            
            #line 912304 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx.cs"
            ((global::System.Web.UI.Page)(this)).AppRelativeVirtualPath = "~/Frames/ReportLauncher.aspx";
            
            #line default
            #line hidden
            if ((global::ASP.frames_reportlauncher_aspx.@__initialized == false)) {
                dependencies = new string[4];
                dependencies[0] = "~/Frames/ReportLauncher.aspx";
                dependencies[1] = "~/Frames/ReportLauncher.aspx.cs";
                dependencies[2] = "~/Controls/PageTitle.ascx";
                dependencies[3] = "~/Controls/PageTitle.ascx.cs";
                global::ASP.frames_reportlauncher_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.frames_reportlauncher_aspx.@__initialized = true;
            }
            this.Server.ScriptTimeout = 30000000;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control2() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3" +
                    ".org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/199" +
                    "9/xhtml\">\r\n");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        194,
                        172,
                        true});
            return @__ctrl;
        }
        
        private static System.Reflection.MethodInfo @__PageInspector_LoadHelper(string helperName) {
            System.Type helperClass = System.Type.GetType("Microsoft.WebTools.BrowserLink.Runtime.WebForms.TraceHelpers, Microsoft.WebTools." +
                    "BrowserLink.Tracing, Version=16.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                    "1d50a3a", false, false);
            if ((helperClass != null)) {
                return helperClass.GetMethod(helperName);
            }
            return null;
        }
        
        private void @__PageInspector_SetTraceData(object[] parameters) {
            if ((global::ASP.frames_reportlauncher_aspx.@__PageInspector_SetTraceDataMethod != null)) {
                global::ASP.frames_reportlauncher_aspx.@__PageInspector_SetTraceDataMethod.Invoke(null, parameters);
            }
        }
        
        private void @__PageInspector_BeginRenderTracing(object[] parameters) {
            if ((global::ASP.frames_reportlauncher_aspx.@__PageInspector_BeginRenderTracingMethod != null)) {
                global::ASP.frames_reportlauncher_aspx.@__PageInspector_BeginRenderTracingMethod.Invoke(null, parameters);
            }
        }
        
        private void @__PageInspector_EndRenderTracing(object[] parameters) {
            if ((global::ASP.frames_reportlauncher_aspx.@__PageInspector_EndRenderTracingMethod != null)) {
                global::ASP.frames_reportlauncher_aspx.@__PageInspector_EndRenderTracingMethod.Invoke(null, parameters);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control5() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("Reports test");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        397,
                        12,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlTitle @__BuildControl__control4() {
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl;
            
            #line 7 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTitle();
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 7 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl1 = this.@__BuildControl__control5();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 7 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        390,
                        27,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlHead @__BuildControl__control3() {
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl;
            
            #line 6 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlHead("head");
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl1;
            
            #line 6 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl1 = this.@__BuildControl__control4();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 6 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        366,
                        60,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control6() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        426,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control8() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t\t");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        598,
                        4,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::ASP.controls_pagetitle_ascx @__BuildControlusrCaption() {
            global::ASP.controls_pagetitle_ascx @__ctrl;
            
            #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::ASP.controls_pagetitle_ascx();
            
            #line default
            #line hidden
            this.usrCaption = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.InitializeAsUserControl(this.Page);
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ID = "usrCaption";
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.EnableTheming = true;
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        602,
                        71,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control9() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t\t<div>\r\n\t\t\t");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        673,
                        14,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXSoapDataSource @__BuildControlds() {
            global::PX.Web.UI.PXSoapDataSource @__ctrl;
            
            #line 14 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::PX.Web.UI.PXSoapDataSource();
            
            #line default
            #line hidden
            this.ds = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 14 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ID = "ds";
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        687,
                        71,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control10() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t\t</div>\r\n\t\t<div class=\"reportToolbar\">\r\n\t\t\t");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        758,
                        46,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXToolBar @__BuildControltlbReport() {
            global::PX.Web.UI.PXToolBar @__ctrl;
            
            #line 18 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::PX.Web.UI.PXToolBar();
            
            #line default
            #line hidden
            this.tlbReport = @__ctrl;
            @__ctrl.SkinID = "Navigation";
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 18 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ID = "tlbReport";
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        804,
                        84,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control11() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t\t</div>\r\n\t\t<div class=\"phF\">\r\n\t\t\t");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        888,
                        36,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control12(PX.Web.UI.PXAutoSizeInfo @__ctrl) {
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.Container = global::PX.Web.UI.DockContainer.Window;
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.Enabled = true;
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXReportViewer @__BuildControlviewer() {
            global::PX.Web.UI.PXReportViewer @__ctrl;
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::PX.Web.UI.PXReportViewer();
            
            #line default
            #line hidden
            this.viewer = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ID = "viewer";
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Percentage);
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.DataSourceID = "ds";
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ToolBarID = "tlbReport";
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.EnableTheming = true;
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            this.@__BuildControl__control12(@__ctrl.AutoSize);
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ReportCreated += new System.EventHandler(this.viewer_ReportCreated);
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ReportLoaded += new System.EventHandler(this.viewer_ReportLoaded);
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.PreRender += new System.EventHandler(this.viewer_ReportPreRender);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        924,
                        331,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control13() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t\t</div>\r\n\t");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        1255,
                        13,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlForm @__BuildControlform1() {
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlForm();
            
            #line default
            #line hidden
            this.form1 = @__ctrl;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.ID = "form1";
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("autocomplete", "off");
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl1 = this.@__BuildControl__control8();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::ASP.controls_pagetitle_ascx @__ctrl2;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl2 = this.@__BuildControlusrCaption();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl3 = this.@__BuildControl__control9();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXSoapDataSource @__ctrl4;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl4 = this.@__BuildControlds();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl4);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl5;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl5 = this.@__BuildControl__control10();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl5);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXToolBar @__ctrl6;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl6 = this.@__BuildControltlbReport();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl6);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl7;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl7 = this.@__BuildControl__control11();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl7);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXReportViewer @__ctrl8;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl8 = this.@__BuildControlviewer();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl8);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl9;
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl9 = this.@__BuildControl__control13();
            
            #line default
            #line hidden
            
            #line 11 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl9);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        547,
                        728,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControl__control7() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            
            #line 9 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("body");
            
            #line default
            #line hidden
            
            #line 9 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "margin: 0px; min-width:300px");
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl1;
            
            #line 9 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl1 = this.@__BuildControlform1();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 9 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control7));
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        428,
                        58,
                        false});
            return @__ctrl;
        }
        
        private void @__Render__control7(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            this.@__PageInspector_EndRenderTracing(new object[] {
                        @__w});
            this.@__PageInspector_BeginRenderTracing(new object[] {
                        @__w,
                        "/AcumaticaTest/Frames/ReportLauncher.aspx",
                        486,
                        3,
                        true});
            @__w.Write("\r\n\t");
            this.@__PageInspector_EndRenderTracing(new object[] {
                        @__w});
            this.@__PageInspector_BeginRenderTracing(new object[] {
                        @__w,
                        "/AcumaticaTest/Frames/ReportLauncher.aspx",
                        489,
                        55,
                        false});
            
            #line 10 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
@__w.Write( ClientSideAppsHelper.RenderScriptConfiguration() );

            
            #line default
            #line hidden
            this.@__PageInspector_EndRenderTracing(new object[] {
                        @__w});
            this.@__PageInspector_BeginRenderTracing(new object[] {
                        @__w,
                        "/AcumaticaTest/Frames/ReportLauncher.aspx",
                        544,
                        3,
                        true});
            @__w.Write("\r\n\t");
            this.@__PageInspector_EndRenderTracing(new object[] {
                        @__w});
            parameterContainer.Controls[0].RenderControl(@__w);
            this.@__PageInspector_BeginRenderTracing(new object[] {
                        @__w,
                        "/AcumaticaTest/Frames/ReportLauncher.aspx",
                        1275,
                        2,
                        true});
            @__w.Write("\r\n");
            this.@__PageInspector_EndRenderTracing(new object[] {
                        @__w});
            this.@__PageInspector_BeginRenderTracing(new object[] {
                        @__w,
                        "/AcumaticaTest/Frames/ReportLauncher.aspx",
                        1277,
                        7,
                        false});
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control14() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n</html>\r\n");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        1284,
                        11,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(frames_reportlauncher_aspx @__ctrl) {
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.EnableViewState = false;
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl.EnableEventValidation = false;
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl2;
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl2 = this.@__BuildControl__control3();
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl3 = this.@__BuildControl__control6();
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl4;
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl4 = this.@__BuildControl__control7();
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl4);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl5;
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__ctrl5 = this.@__BuildControl__control14();
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx"
            @__parser.AddParsedSubObject(@__ctrl5);
            
            #line default
            #line hidden
        }
        
        
        #line 912304 "C:\Users\jknauf\Documents\GitHub\AcumaticaTest\AcumaticaTest\Frames\ReportLauncher.aspx.cs"
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            this.StyleSheetTheme = "Default";
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.frames_reportlauncher_aspx.@__fileDependencies);
            this.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Disabled;
        }
        
        #line default
        #line hidden
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return 1233973648;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}
