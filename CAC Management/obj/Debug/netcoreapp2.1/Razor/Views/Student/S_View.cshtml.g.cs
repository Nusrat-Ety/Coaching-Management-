#pragma checksum "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "484ae56c3fbf19e637ebc30eb49945e67074c889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_S_View), @"mvc.1.0.view", @"/Views/Student/S_View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/S_View.cshtml", typeof(AspNetCore.Views_Student_S_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484ae56c3fbf19e637ebc30eb49945e67074c889", @"/Views/Student/S_View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc153028af1aa2c03cf9b12a9032f9b2940bf6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_S_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CAC_Management.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #309369;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
  
    ViewData ["Title"] = "Update Student Information";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
            BeginContext(135, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(136, 1157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee15c7c2bfd74c97807e54d1a2fd0273", async() => {
                BeginContext(200, 75, true);
                WriteLiteral("\n\n<h1 style=\"text-align:center\" > <strong > Student List </strong > </h1 >\n");
                EndContext();
#line 10 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
 if (ViewBag.msg != null) {

#line default
#line hidden
                BeginContext(303, 50, true);
                WriteLiteral("    <center><h3><strong><label style=\"color:red;\">");
                EndContext();
                BeginContext(354, 11, false);
#line 11 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                             Write(ViewBag.msg);

#line default
#line hidden
                EndContext();
                BeginContext(365, 32, true);
                WriteLiteral("</label></strong></h3></center>\n");
                EndContext();
#line 12 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
}

#line default
#line hidden
                BeginContext(399, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 14 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
 using (Html.BeginForm("StudentList", "StudentController", FormMethod.Post)) {

#line default
#line hidden
                BeginContext(479, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(483, 796, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1ee834e80a641b2be216f8e60386bb4", async() => {
                    BeginContext(526, 248, true);
                    WriteLiteral("\n    <table class=\"table table-bordered\" >\n    <tr >\n\n    <th > Student Id</th >\n    <th > Student Name</th >\n    <th > Gender</th >\n    <th > Address</th >\n    <th > Contact</th >\n    <th style=\"text-align:center;\" > Email</th >\n   \n\n\n    </tr >\n\n");
                    EndContext();
#line 30 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
     foreach (var ac in Model) {

#line default
#line hidden
                    BeginContext(807, 43, true);
                    WriteLiteral("        <tr> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(851, 12, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                      Write(ac.StudentId);

#line default
#line hidden
                    EndContext();
                    BeginContext(863, 36, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(900, 14, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                                                                       Write(ac.StudentName);

#line default
#line hidden
                    EndContext();
                    BeginContext(914, 36, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(951, 9, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                                                                                                                          Write(ac.Gender);

#line default
#line hidden
                    EndContext();
                    BeginContext(960, 36, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(997, 10, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                                                                                                                                                                        Write(ac.Address);

#line default
#line hidden
                    EndContext();
                    BeginContext(1007, 36, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1044, 10, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                                                                                                                                                                                                                       Write(ac.Contact);

#line default
#line hidden
                    EndContext();
                    BeginContext(1054, 36, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1091, 8, false);
#line 31 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                                                                                                                                                                                                                                                                      Write(ac.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(1099, 49, true);
                    WriteLiteral("</td> <td style=\"text-align:center\">\n\n\n}\n\n\n<td > ");
                    EndContext();
                    BeginContext(1148, 96, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32fb7fbf9c34711923102e7fb520570", async() => {
                        BeginContext(1232, 7, true);
                        WriteLiteral(" Delete");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 37 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
                                      WriteLiteral(ac.StudentId);

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
                    BeginContext(1244, 15, true);
                    WriteLiteral(" </td >\n</tr >\n");
                    EndContext();
#line 39 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
}

#line default
#line hidden
                    BeginContext(1261, 10, true);
                    WriteLiteral("</table >\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1279, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 42 "G:\Coaching_Management-master\CAC Management\Views\Student\S_View.cshtml"
}

#line default
#line hidden
                BeginContext(1282, 3, true);
                WriteLiteral("\n\n\n");
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
            BeginContext(1293, 3, true);
            WriteLiteral("\n}\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CAC_Management.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591