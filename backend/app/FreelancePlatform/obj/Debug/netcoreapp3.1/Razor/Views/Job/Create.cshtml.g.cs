#pragma checksum "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a46caa233159efc1009d215897ccbc7d030da6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Create), @"mvc.1.0.view", @"/Views/Job/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\_ViewImports.cshtml"
using FreelancePlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\_ViewImports.cshtml"
using FreelancePlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
using FreelancePlatform.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a46caa233159efc1009d215897ccbc7d030da6", @"/Views/Job/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec94f2dd4cb08c7ba20872607a856316c25de0e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelancePlatform.Models.Job>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logof.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 290px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Full time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Part time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Internship", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "web-design", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "graphic-design", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "web-development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "human-resource", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "support", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "android", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("job-main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("job-add-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
   ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<header class=\"main-header\">\r\n    <div class=\"container\">\r\n        <div class=\"text-center logo\"> <a href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12a46caa233159efc1009d215897ccbc7d030da69850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a></div>
    </div>
    </div>
</header>

<div class=""body-content clearfix"">

    <div class=""bg-color2 block-section line-bottom"">
        <div class=""container"">
            <h1 class=""text-center no-margin"">Publiko Shpallje</h1>
        </div>
    </div>

    <div class=""bg-color1 block-section line-bottom"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 col-md-offset-2"">

                    <!-- form post a job -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da611578", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                   Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <h4>Detajet e shpalljes</h4>
                                <p class=""text-muted text-small"">
                                    Disa informacione shtesë për këtë formë në lidhje me vlefshmërinë e
                                    reklamat, etj. Tristique senectus et netus et malesuada
                                    fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget,
                                    tempor rri amet, ante. Donec eu libero ulet amet quam egestas semper. Enean
                                    ultricies mi vitae est. Maurice place eleifend leo. Quisque ulen amet est dhe sapien
                                    faretra ullamcorper.
                                </p>
                                <hr>
                            </div>
                        </div>
                        <div class=""row"">
  ");
                WriteLiteral("                          <div");
                BeginWriteAttribute("class", " class=\"", 2157, "\"", 2245, 3);
                WriteAttributeValue("", 2165, "col-lg-12", 2165, 9, true);
                WriteAttributeValue(" ", 2174, "form-group", 2175, 11, true);
#nullable restore
#line 48 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
WriteAttributeValue(" ", 2185, Html.AddClassIfPropertyInError(x => x.Title, "is-invalid"), 2186, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 49 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 50 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <span class=\"help-inline\">");
#nullable restore
#line 51 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                                                     Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-12 form-group\">\r\n                                ");
#nullable restore
#line 56 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 57 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control", rows = 5 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <span class=\"help-inline\">");
#nullable restore
#line 58 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                                                     Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                ");
#nullable restore
#line 63 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 64 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Location, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <span class=\"help-inline\">");
#nullable restore
#line 65 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                                                     Write(Html.ValidationMessageFor(x => x.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"col-lg-6 form-group\">\r\n                                ");
#nullable restore
#line 68 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <select id=\"type\" name=\"Type\" placeholder=\"Zgjedh llojin e punës\"\r\n                                        class=\"form-control select2\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da618595", async() => {
                    WriteLiteral("Full time");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da619858", async() => {
                    WriteLiteral("Part time");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da621121", async() => {
                    WriteLiteral("Internship");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 form-group"">
                                <label for=""category"">Category</label>
                                <select id=""category"" name=""category"" placeholder=""Zgjedh kategorin:""
                                        class=""form-control select2"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da622862", async() => {
                    WriteLiteral("Web design");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da624126", async() => {
                    WriteLiteral("Graphic design");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da625394", async() => {
                    WriteLiteral("Web development");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da626663", async() => {
                    WriteLiteral("Human Resources");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da627932", async() => {
                    WriteLiteral("Support");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a46caa233159efc1009d215897ccbc7d030da629195", async() => {
                    WriteLiteral("Android");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xl-6 form-group"">
                                <label for=""apply_url"">
                                    Vendos URL <span class=""note"">(Perdoruesit do te aplikojne ne website tuaj)</span>
                                </label>
                                <input id=""apply_url"" type=""url"" class=""form-control"">
                            </div>
                            <div class=""col-xl-6 form-group"">
                                ");
#nullable restore
#line 99 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.LastDate, "Validity of the post"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 100 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.LastDate, new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <hr class=""margin-bottom--big"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <h4>Detajet e kompanis</h4>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 form-group"">
                                ");
#nullable restore
#line 117 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.CompanyName, "Company Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 118 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.CompanyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-12 form-group\">\r\n                                ");
#nullable restore
#line 123 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.CompanyDescription, "Company Description"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 124 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextAreaFor(m => m.CompanyDescription, new { @class = "form-control", rows = 3 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-4 form-group\">\r\n                                ");
#nullable restore
#line 129 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.LabelFor(c => c.Website, "Company Website"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 130 "D:\DATA\UBT\UBT\Semestri 6\LAB2\Ardit-Jashari,Granit-Zenelaj-Freelancing_Platform\Projekti\Projekti\FreelancePlatform\Views\Job\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Website, new { @class = "form-control", @type = "url" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <hr>
                                <div class=""checkbox text-center"">
                                    <label>
                                        <input type=""checkbox""> Une pajtohem me  <a href=""#"">Terms and conditions</a>.
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 text-center"">
                                <hr>
                                <button type=""submit"" class=""btn btn-outline-white-primary"">
                                    <i class=""fa fa-magic""></i>
                                    Ruaj dhe publiko
                                </button>
                            </d");
                WriteLiteral("iv>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div><!--end body-content -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelancePlatform.Models.Job> Html { get; private set; }
    }
}
#pragma warning restore 1591
