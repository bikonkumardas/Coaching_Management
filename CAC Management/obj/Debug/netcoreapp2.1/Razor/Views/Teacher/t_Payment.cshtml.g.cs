#pragma checksum "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3c09e4d3b05735758e7a8e6c5d8da184306526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_t_Payment), @"mvc.1.0.view", @"/Views/Teacher/t_Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/t_Payment.cshtml", typeof(AspNetCore.Views_Teacher_t_Payment))]
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
#line 1 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management;

#line default
#line hidden
#line 2 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e3c09e4d3b05735758e7a8e6c5d8da184306526", @"/Views/Teacher/t_Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d480e88fc2ea1a4d87350da6cf5607cfa8fe1ad9", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_t_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CAC_Management.Models.Teacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #309369;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
  
    Layout = "_LayoutForTeacher";


#line default
#line hidden
            BeginContext(91, 55, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Teachers Payment</h1>\r\n");
            EndContext();
            BeginContext(146, 1837, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3081dd15463445e81a9ded3268ccf13", async() => {
                BeginContext(209, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(704, 539, true);
                WriteLiteral(@"
    <div class=""container"">
        <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
            <thead>
                <tr>
                    <th style=""text-align:center; font-weight: bold;"">Teacher Name</th>
                    <th style=""text-align:center; font-weight: bold;"">Salary</th>
                    <th style=""text-align:center; font-weight: bold;"">Paid Amount</th>
                    <th style=""text-align:center; font-weight: bold;"">Payment Status</th>
                </tr>

");
                EndContext();
#line 31 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                 foreach (var f in Model)
                {

#line default
#line hidden
                BeginContext(1305, 80, true);
                WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1386, 13, false);
#line 34 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                                                 Write(f.TeacherName);

#line default
#line hidden
                EndContext();
                BeginContext(1399, 61, true);
                WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1461, 8, false);
#line 35 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                                                 Write(f.Salary);

#line default
#line hidden
                EndContext();
                BeginContext(1469, 61, true);
                WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1531, 12, false);
#line 36 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                                                 Write(f.PaidAmount);

#line default
#line hidden
                EndContext();
                BeginContext(1543, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 37 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                         if (f.Payment_Status == 0)
                        {

#line default
#line hidden
                BeginContext(1630, 69, true);
                WriteLiteral("                            <td style=\"text-align:center\">Paid</td>\r\n");
                EndContext();
#line 40 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1783, 68, true);
                WriteLiteral("                            <td style=\"text-align:center\">Due</td>\r\n");
                EndContext();
#line 44 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                        }

#line default
#line hidden
                BeginContext(1878, 27, true);
                WriteLiteral("                    </tr>\r\n");
                EndContext();
#line 46 "E:\I U B A T\Project\A4\Project\CAC Management\CAC Management\Views\Teacher\t_Payment.cshtml"
                }

#line default
#line hidden
                BeginContext(1924, 52, true);
                WriteLiteral("            </thead>\r\n        </table>\r\n    </div>\r\n");
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
            BeginContext(1983, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CAC_Management.Models.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
