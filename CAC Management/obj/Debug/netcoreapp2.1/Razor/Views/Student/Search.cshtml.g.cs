#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a71f1b89a10f693735b304d5c4d18acd6bb999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Search), @"mvc.1.0.view", @"/Views/Student/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Search.cshtml", typeof(AspNetCore.Views_Student_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a71f1b89a10f693735b304d5c4d18acd6bb999", @"/Views/Student/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAC_Management.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #45CD93;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
  
    ViewData["Title"] = "Student Details";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
            BeginContext(117, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(118, 1968, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f350937356a94fd5b7194cf6f11b22d9", async() => {
                BeginContext(181, 1193, true);
                WriteLiteral(@"
    <h1 style=""text-align:center"">Student Information Details</h1>

    <div class=""container"">
        <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
            <thead>
                <tr>
                    <td style=""text-align:center; font-weight: bold;"">Student Id</td>
                    <td style=""text-align:center; font-weight: bold;"">Student Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Father Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Mother Name</td>
                    <td style=""text-align:center; font-weight: bold;"">DOB</td>
                    <td style=""text-align:center; font-weight: bold;"">Gender</td>
                    <td style=""text-align:center; font-weight: bold;"">Address</td>
                    <td style=""text-align:center; font-weight: bold;"">Contact</td>
                    <td style=""text-align:center; font-weight: bold;"">Email</td>
                    <td style=""text-align:");
                WriteLiteral("center; font-weight: bold;\">Password</td>\n                    \n                </tr>\n            </thead>\n            <tr>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1375, 15, false);
#line 28 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.StudentId);

#line default
#line hidden
                EndContext();
                BeginContext(1390, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1443, 17, false);
#line 29 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.StudentName);

#line default
#line hidden
                EndContext();
                BeginContext(1460, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1513, 16, false);
#line 30 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.FatherName);

#line default
#line hidden
                EndContext();
                BeginContext(1529, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1582, 16, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.MotherName);

#line default
#line hidden
                EndContext();
                BeginContext(1598, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1651, 9, false);
#line 32 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.DOB);

#line default
#line hidden
                EndContext();
                BeginContext(1660, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1713, 12, false);
#line 33 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Gender);

#line default
#line hidden
                EndContext();
                BeginContext(1725, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1778, 13, false);
#line 34 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(1791, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1844, 13, false);
#line 35 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Contact);

#line default
#line hidden
                EndContext();
                BeginContext(1857, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1910, 11, false);
#line 36 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1921, 52, true);
                WriteLiteral("</td>\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1974, 14, false);
#line 37 "G:\Coaching_Management-master\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Password);

#line default
#line hidden
                EndContext();
                BeginContext(1988, 91, true);
                WriteLiteral("</td>\n\n                \n                \n            </tr>\n        </table>\n    </div>\n    ");
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
            BeginContext(2086, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAC_Management.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
