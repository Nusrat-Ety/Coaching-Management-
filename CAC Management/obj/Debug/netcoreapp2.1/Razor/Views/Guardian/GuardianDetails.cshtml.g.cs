#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a875587c381221c74d103d2af1c36d79bbb606e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guardian_GuardianDetails), @"mvc.1.0.view", @"/Views/Guardian/GuardianDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Guardian/GuardianDetails.cshtml", typeof(AspNetCore.Views_Guardian_GuardianDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a875587c381221c74d103d2af1c36d79bbb606e", @"/Views/Guardian/GuardianDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Guardian_GuardianDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAC_Management.Models.Guardian>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("        background-color: #db937b;\n        align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
   ViewData["Title"] = "Guardian Details";
    Layout = "_LayoutForAdmin"; 

#line default
#line hidden
            BeginContext(116, 5, true);
            WriteLiteral("<hr>\n");
            EndContext();
            BeginContext(121, 1774, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cd0589fea8043de80db834d8d0516c0", async() => {
                BeginContext(201, 139, true);
                WriteLiteral("\n    <h1 style=\"text-align:center\">Guardian Details</h1>\n\n    <div class=\"container\" style=\"width: 20%;\">\n        <div class=\"form-group\">\n");
                EndContext();
                BeginContext(718, 766, true);
                WriteLiteral(@"        </div>
    </div>

    <div class=""container"">
        <table border=""1"" class=""table table-bordered"">
            <thead>
                <tr>
                    <td style=""text-align:center; font-weight: bold;"">Guardian Id</td>
                    <td style=""text-align:center; font-weight: bold;"">Guardian Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Contact</td>
                    <td style=""text-align:center; font-weight: bold;"">Address</td>
                    <td style=""text-align:center; font-weight: bold;"">Email</td>
                    <td style=""text-align:center; font-weight: bold;"">Password</td>

                </tr>
            </thead>
            <tr>
                <td style=""text-align:center"">");
                EndContext();
                BeginContext(1485, 16, false);
#line 35 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.GuardianId);

#line default
#line hidden
                EndContext();
                BeginContext(1501, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1554, 18, false);
#line 36 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.GuardianName);

#line default
#line hidden
                EndContext();
                BeginContext(1572, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1625, 13, false);
#line 37 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.Contact);

#line default
#line hidden
                EndContext();
                BeginContext(1638, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1691, 13, false);
#line 38 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(1704, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1757, 11, false);
#line 39 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1768, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1821, 14, false);
#line 40 "G:\Coaching_Management-master\CAC Management\Views\Guardian\GuardianDetails.cshtml"
                                         Write(Model.Password);

#line default
#line hidden
                EndContext();
                BeginContext(1835, 53, true);
                WriteLiteral("</td>\n\n            </tr>\n        </table>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAC_Management.Models.Guardian> Html { get; private set; }
    }
}
#pragma warning restore 1591
