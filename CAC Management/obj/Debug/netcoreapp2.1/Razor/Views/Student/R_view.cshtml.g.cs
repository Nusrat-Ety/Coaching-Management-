#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9381f51807a7a46c5a37805536d5d76446186cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_R_view), @"mvc.1.0.view", @"/Views/Student/R_view.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/R_view.cshtml", typeof(AspNetCore.Views_Student_R_view))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9381f51807a7a46c5a37805536d5d76446186cb1", @"/Views/Student/R_view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_R_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CAC_Management.Models.Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResultSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "StudentName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "R_search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #db937b;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
   Layout = "_LayoutForStudent";
    ViewData["Title"] = "R_View"; 

#line default
#line hidden
            BeginContext(118, 2530, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b673b160ed44e39ac59713fc44b6523", async() => {
                BeginContext(181, 84, true);
                WriteLiteral("\n    <div style=\"margin:15px;\">\n        <div class=\"input-group-addon\">\n            ");
                EndContext();
                BeginContext(265, 299, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d366dea3ff54124bc02a03af6551eed", async() => {
                    BeginContext(318, 103, true);
                    WriteLiteral("\n                <input placeholder=\"Search By name\" class=\"form-control\" name=\"id\" />\n                ");
                    EndContext();
                    BeginContext(421, 123, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9f688247cc74744b1b0217459dcd6e8", async() => {
                        BeginContext(502, 38, true);
                        WriteLiteral("<input type=\"submit\" value=\"search\" />");
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
                    BeginContext(544, 13, true);
                    WriteLiteral("\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(564, 229, true);
                WriteLiteral("\n        </div>\n        <h2><center> <strong> Result  </strong></center></h2>\n        <br />\n        <table class=\"table table-bordered\">\n            <tr>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(794, 54, false);
#line 18 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().StudentId));

#line default
#line hidden
                EndContext();
                BeginContext(848, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(976, 56, false);
#line 23 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().StudentName));

#line default
#line hidden
                EndContext();
                BeginContext(1032, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(1160, 52, false);
#line 28 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().Subject));

#line default
#line hidden
                EndContext();
                BeginContext(1212, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(1340, 50, false);
#line 33 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().Marks));

#line default
#line hidden
                EndContext();
                BeginContext(1390, 164, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        <strong>\n                            ");
                EndContext();
                BeginContext(1555, 56, false);
#line 39 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().Performance));

#line default
#line hidden
                EndContext();
                BeginContext(1611, 310, true);
                WriteLiteral(@"
                        </strong>
                    </center>
                </th>
                <th>
                    <center>
                        <strong>
                            Action
                        </strong>
                    </center>
                </th>
            </tr>

");
                EndContext();
#line 52 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1976, 59, true);
                WriteLiteral("    <tr>\n        <td>\n            <center>\n                ");
                EndContext();
                BeginContext(2036, 36, false);
#line 57 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
           Write(Html.DisplayFor(p => item.StudentId));

#line default
#line hidden
                EndContext();
                BeginContext(2072, 88, true);
                WriteLiteral("\n            </center>\n\n        </td>\n        <td>\n            <center>\n                ");
                EndContext();
                BeginContext(2161, 38, false);
#line 63 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
           Write(Html.DisplayFor(p => item.StudentName));

#line default
#line hidden
                EndContext();
                BeginContext(2199, 93, true);
                WriteLiteral("\n            </center>\n\n        </td>\n\n\n\n        <td>\n\n\n            <center>\n                ");
                EndContext();
                BeginContext(2293, 34, false);
#line 74 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
           Write(Html.DisplayFor(p => item.Subject));

#line default
#line hidden
                EndContext();
                BeginContext(2327, 88, true);
                WriteLiteral("\n            </center>\n\n        </td>\n        <td>\n            <center>\n                ");
                EndContext();
                BeginContext(2416, 32, false);
#line 80 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
           Write(Html.DisplayFor(p => item.Marks));

#line default
#line hidden
                EndContext();
                BeginContext(2448, 88, true);
                WriteLiteral("\n            </center>\n\n        </td>\n        <td>\n            <center>\n                ");
                EndContext();
                BeginContext(2537, 38, false);
#line 86 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
           Write(Html.DisplayFor(p => item.Performance));

#line default
#line hidden
                EndContext();
                BeginContext(2575, 35, true);
                WriteLiteral("\n\n\n            </center>\n\n    </tr>");
                EndContext();
#line 91 "G:\Coaching_Management-master\CAC Management\Views\Student\R_view.cshtml"
         }

#line default
#line hidden
                BeginContext(2612, 29, true);
                WriteLiteral("\n        </table>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CAC_Management.Models.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
