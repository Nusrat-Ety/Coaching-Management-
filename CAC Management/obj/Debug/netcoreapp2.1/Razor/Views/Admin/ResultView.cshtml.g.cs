#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8461b34b398a52f209b1920c5ed1c9044cf647de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ResultView), @"mvc.1.0.view", @"/Views/Admin/ResultView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ResultView.cshtml", typeof(AspNetCore.Views_Admin_ResultView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8461b34b398a52f209b1920c5ed1c9044cf647de", @"/Views/Admin/ResultView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ResultView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CAC_Management.Models.Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #db937b;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
   Layout = "_LayoutForAdmin";
    ViewData["Title"] = "ResultView"; 

#line default
#line hidden
            BeginContext(120, 2404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7cdb8de91b8416988d21d06dbdaece7", async() => {
                BeginContext(183, 117, true);
                WriteLiteral("\n    <div style=\"margin:15px;\">\n        <h2><center> <strong> Result  </strong></center></h2>\n        <br />\n        ");
                EndContext();
                BeginContext(300, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77778ff7e4b34994ae9f80cd80c852fe", async() => {
                    BeginContext(350, 13, true);
                    WriteLiteral("Create Result");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 138, true);
                WriteLiteral("\n\n        <table class=\"table table-bordered\">\n            <tr>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(506, 54, false);
#line 14 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().StudentId));

#line default
#line hidden
                EndContext();
                BeginContext(560, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(688, 56, false);
#line 19 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().StudentName));

#line default
#line hidden
                EndContext();
                BeginContext(744, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(872, 52, false);
#line 24 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().Subject));

#line default
#line hidden
                EndContext();
                BeginContext(924, 127, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        ");
                EndContext();
                BeginContext(1052, 50, false);
#line 29 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().Marks));

#line default
#line hidden
                EndContext();
                BeginContext(1102, 164, true);
                WriteLiteral("\n                    </center>\n                </th>\n                <th>\n                    <center>\n                        <strong>\n                            ");
                EndContext();
                BeginContext(1267, 56, false);
#line 35 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().Performance));

#line default
#line hidden
                EndContext();
                BeginContext(1323, 310, true);
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
#line 48 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1688, 43, true);
                WriteLiteral("<tr>\n    <td>\n        <center>\n            ");
                EndContext();
                BeginContext(1732, 36, false);
#line 53 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
       Write(Html.DisplayFor(p => item.StudentId));

#line default
#line hidden
                EndContext();
                BeginContext(1768, 68, true);
                WriteLiteral("\n        </center>\n\n    </td>\n    <td>\n        <center>\n            ");
                EndContext();
                BeginContext(1837, 38, false);
#line 59 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
       Write(Html.DisplayFor(p => item.StudentName));

#line default
#line hidden
                EndContext();
                BeginContext(1875, 73, true);
                WriteLiteral("\n        </center>\n\n    </td>\n\n\n\n    <td>\n\n\n        <center>\n            ");
                EndContext();
                BeginContext(1949, 34, false);
#line 70 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
       Write(Html.DisplayFor(p => item.Subject));

#line default
#line hidden
                EndContext();
                BeginContext(1983, 68, true);
                WriteLiteral("\n        </center>\n\n    </td>\n    <td>\n        <center>\n            ");
                EndContext();
                BeginContext(2052, 32, false);
#line 76 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
       Write(Html.DisplayFor(p => item.Marks));

#line default
#line hidden
                EndContext();
                BeginContext(2084, 68, true);
                WriteLiteral("\n        </center>\n\n    </td>\n    <td>\n        <center>\n            ");
                EndContext();
                BeginContext(2153, 38, false);
#line 82 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
       Write(Html.DisplayFor(p => item.Performance));

#line default
#line hidden
                EndContext();
                BeginContext(2191, 67, true);
                WriteLiteral("\n\n\n        </center>\n    </td>\n    <td style=\"text-align:center\">\n\n");
                EndContext();
                BeginContext(2355, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2363, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a63a4f94b94042a6dd9ff67d24e550", async() => {
                    BeginContext(2448, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 90 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                                        WriteLiteral(item.StudentId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2458, 28, true);
                WriteLiteral("\n    </td>\n</tr>            ");
                EndContext();
#line 92 "G:\Coaching_Management-master\CAC Management\Views\Admin\ResultView.cshtml"
                 }

#line default
#line hidden
                BeginContext(2488, 29, true);
                WriteLiteral("\n        </table>\n    </div>\n");
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
