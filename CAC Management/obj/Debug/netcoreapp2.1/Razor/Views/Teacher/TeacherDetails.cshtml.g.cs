#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e78e0dc301c5ebc991714a7b4cd20fe16290f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherDetails), @"mvc.1.0.view", @"/Views/Teacher/TeacherDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/TeacherDetails.cshtml", typeof(AspNetCore.Views_Teacher_TeacherDetails))]
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
#line 1 "G:\Coaching_Management-master\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management;

#line default
#line hidden
#line 2 "G:\Coaching_Management-master\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e78e0dc301c5ebc991714a7b4cd20fe16290f2", @"/Views/Teacher/TeacherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAC_Management.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("        background-color: #db937b;\r\n        align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
  
    ViewData["Title"] = "Teacher Details";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
            BeginContext(118, 5, true);
            WriteLiteral("<hr>\n");
            EndContext();
            BeginContext(123, 1803, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1626c24fff34418bb77f4c911a317439", async() => {
                BeginContext(204, 198, true);
                WriteLiteral("\n    <h1 style=\"text-align:center\">Teacher Details</h1>\n\n    <div class=\"container\" style=\"width: 20%;\">\n        <div class=\"form-group\">\n            <div class=\"input-group-addon\">\n                ");
                EndContext();
                BeginContext(402, 292, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d655d9fd5ee44b4a0f4af9b99247f2b", async() => {
                    BeginContext(453, 109, true);
                    WriteLiteral("\n                    <input placeholder=\"Search By Id\" class=\"form-control\" name=\"id\" />\n                    ");
                    EndContext();
                    BeginContext(562, 108, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e50971351fb43489b823f0ae9a65563", async() => {
                        BeginContext(628, 38, true);
                        WriteLiteral("<input type=\"submit\" value=\"Search\" />");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(670, 17, true);
                    WriteLiteral("\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 803, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""container"">
        <table border=""1"" class=""table table-bordered"">
            <thead>
                <tr>
                    <td style=""text-align:center; font-weight: bold;"">Teacher Id</td>
                    <td style=""text-align:center; font-weight: bold;"">Teacher Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Contact</td>
                    <td style=""text-align:center; font-weight: bold;"">Address</td>
                    <td style=""text-align:center; font-weight: bold;"">Email</td>
                    <td style=""text-align:center; font-weight: bold;"">Password</td>
                   
                </tr>
            </thead>
            <tr>
                <td style=""text-align:center"">");
                EndContext();
                BeginContext(1498, 15, false);
#line 37 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.TeacherId);

#line default
#line hidden
                EndContext();
                BeginContext(1513, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1566, 17, false);
#line 38 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.TeacherName);

#line default
#line hidden
                EndContext();
                BeginContext(1583, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1636, 13, false);
#line 39 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.Contact);

#line default
#line hidden
                EndContext();
                BeginContext(1649, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1702, 13, false);
#line 40 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(1715, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1768, 11, false);
#line 41 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1779, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1832, 14, false);
#line 42 "G:\Coaching_Management-master\CAC Management\Views\Teacher\TeacherDetails.cshtml"
                                         Write(Model.Password);

#line default
#line hidden
                EndContext();
                BeginContext(1846, 73, true);
                WriteLiteral("</td>\n                \n            </tr>\n        </table>\n    </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1926, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAC_Management.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
