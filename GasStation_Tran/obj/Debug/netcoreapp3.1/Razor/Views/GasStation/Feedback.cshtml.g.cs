#pragma checksum "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da6986ea4f88a8a253875a40172614a10035769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GasStation_Feedback), @"mvc.1.0.view", @"/Views/GasStation/Feedback.cshtml")]
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
#line 1 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\_ViewImports.cshtml"
using GasStation_Tran;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\_ViewImports.cshtml"
using GasStation_Tran.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da6986ea4f88a8a253875a40172614a10035769", @"/Views/GasStation/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b03e961d6235c2646e093755f669a9cc9d5411", @"/Views/_ViewImports.cshtml")]
    public class Views_GasStation_Feedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GasStation_Tran.ViewModels.GasStationViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
  
    var msg = ViewData["MessageTable"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da6986ea4f88a8a253875a40172614a100357694208", async() => {
                WriteLiteral(@"
        <input type=""hidden"" value=""0"" id=""SelectPage"" name=""SelectPage"" />
        <div class=""row justify-content-center"" style=""font-weight:600"">
            <label>
                <h3>
                    投稿の閲覧
                </h3>
            </label>
        </div>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""fname"" style=""font-weight:600"">ガソリンスタンド名</label>
            </div>
            <div class=""col-75"">
                <label>");
#nullable restore
#line 21 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                  Write(Model.GasStationFeedback.GasStationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-25\">\r\n                <label for=\"lname\" style=\"font-weight:600\">種類</label>\r\n            </div>\r\n            <div class=\"col-75\">\r\n                <label>");
#nullable restore
#line 29 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                  Write(Model.GasStationFeedback.GasStationType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-25\">\r\n                <label for=\"fname\" style=\"font-weight:600\">住所</label>\r\n            </div>\r\n            <div class=\"col-75\">\r\n                <label>");
#nullable restore
#line 37 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                  Write(Model.GasStationFeedback.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 37 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                                                     Write(!string.IsNullOrEmpty(Model.GasStationFeedback.Address)?",":"");

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                                                                                                                     Write(Model.GasStationFeedback.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""fname"" style=""font-weight:600"">開館時間</label>
            </div>
            <div class=""col-75"">
                <label>");
#nullable restore
#line 45 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                  Write(Model.GasStationFeedback.OpeningTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""fname"" style=""font-weight:600"">評価</label>
            </div>
            <div class=""col-75"">
                <label>
");
#nullable restore
#line 54 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                     switch (Model.GasStationFeedback.TypeCode)
                    {
                        case "00001":

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td><i style=\"color:red;font-size:20px\" class=\"fas fa-certificate\"></i></td>\r\n");
#nullable restore
#line 58 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                            break;
                        case "00002":

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td><i style=\"color:blue;font-size:20px\" class=\"fas fa-certificate\"></i></td>\r\n");
#nullable restore
#line 61 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                            break;
                        case "00003":

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td><i style=\"color:gray;font-size:20px\" class=\"fas fa-certificate\"></i></td>\r\n");
#nullable restore
#line 64 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                            break;
                        default:
                            break;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" >\r\n");
#nullable restore
#line 72 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
             if (msg != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 75 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
               Write(msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 77 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                 foreach (var item in Model.lstGasStationFeedback)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row card\">\r\n                        <div class=\"card-header\">\r\n                            ");
#nullable restore
#line 84 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                       Write(item.FeedbackAt.ToString("yy年MM月dd日"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 87 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                                            Write(item.Feedback);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul class=\"pagination row justify-content-end mr-3\">\r\n\r\n");
#nullable restore
#line 94 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                  if (msg == null)
                    {
                        var totalPage = Convert.ToInt32(ViewBag.Page.ToString());

                        if (ViewBag.CurrentPageView != 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link text-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3845, "\"", 3907, 5);
                WriteAttributeValue("", 3855, "changePage(parseInt(\'", 3855, 21, true);
#nullable restore
#line 101 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
WriteAttributeValue("", 3876, ViewBag.CurrentPageView, 3876, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3900, "\')", 3900, 2, true);
                WriteAttributeValue(" ", 3902, "-", 3903, 2, true);
                WriteAttributeValue(" ", 3904, "1)", 3905, 3, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-arrow-left\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 103 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"page-item disabled\">\r\n                                <a class=\"page-link text-dark\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\"><i class=\"fa fa-arrow-left\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 109 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                        }
                        for (int i = 0; i < totalPage + 1; i++)
                        {
                            if (i != ViewBag.CurrentPageView)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4632, "\"", 4656, 3);
                WriteAttributeValue("", 4642, "changePage(", 4642, 11, true);
#nullable restore
#line 115 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
WriteAttributeValue("", 4653, i, 4653, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4655, ")", 4655, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 116 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 119 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"page-item active\" aria-current=\"page\">\r\n                                    <a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5024, "\"", 5048, 3);
                WriteAttributeValue("", 5034, "changePage(", 5034, 11, true);
#nullable restore
#line 123 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
WriteAttributeValue("", 5045, i, 5045, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5047, ")", 5047, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 123 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                                                                              Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                                </li>\r\n");
#nullable restore
#line 125 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                            }
                        }
                        if (ViewBag.CurrentPageView == totalPage)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"page-item disabled\">\r\n                                <a class=\"page-link text-dark\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\"><i class=\"fa fa-arrow-right\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 132 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link text-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5735, "\"", 5797, 5);
                WriteAttributeValue("", 5745, "changePage(parseInt(\'", 5745, 21, true);
#nullable restore
#line 136 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
WriteAttributeValue("", 5766, ViewBag.CurrentPageView, 5766, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5790, "\')", 5790, 2, true);
                WriteAttributeValue(" ", 5792, "+", 5793, 2, true);
                WriteAttributeValue(" ", 5794, "1)", 5795, 3, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-arrow-right\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 138 "E:\projectWebApp\GasStation_Tran\GasStation_Tran\Views\GasStation\Feedback.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </ul>
        </div>

        <div class=""row"">
            <div class=""col-25"">
                <a class=""btn btn-primary"" href=""/GasStation/Index"">戻る</a>
            </div>
            <div class=""col-75"">
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n    function changePage(currentPage) {\r\n        $(\'#SelectPage\').val(currentPage);\r\n        $(\'#formView\').submit();\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GasStation_Tran.ViewModels.GasStationViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591