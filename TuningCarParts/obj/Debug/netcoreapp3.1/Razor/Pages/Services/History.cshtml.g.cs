#pragma checksum "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0805f71c663822618bb1aced873cb65856b74c1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TuningCarParts.Pages.Services.Pages_Services_History), @"mvc.1.0.razor-page", @"/Pages/Services/History.cshtml")]
namespace TuningCarParts.Pages.Services
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
#line 1 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\_ViewImports.cshtml"
using TuningCarParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\_ViewImports.cshtml"
using TuningCarParts.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0805f71c663822618bb1aced873cb65856b74c1d", @"/Pages/Services/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86f4bd0e84dd65bbb2f6e8c4630a6649f2cb386", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Services_History : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Cars/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
  
    ViewData["Title"] = "History";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container pt-4 pb-2 row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info py-2\">Service History</h2>\r\n    </div>\r\n    <div class=\"col-3 offset-3 text-right py-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0805f71c663822618bb1aced873cb65856b74c1d5152", async() => {
                WriteLiteral(" Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                          WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
 if (Model.ServiceHeader.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"backgroundWhite\">\r\n        <p>No Service record found...</p>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container backgroundWhite"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light ml-0 row container"">
                <div class=""col-1 text-center pt-3 text-white-50 "">
                    <i class=""far fa-user fa-2x""></i>
                </div>
                <div class=""col-5"">
                    <label class=""text-info"">");
#nullable restore
#line 32 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                    <label class=\"text-info\">");
#nullable restore
#line 33 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.ApplicationUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 33 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                                                                            Write(Model.ServiceHeader[0].Car.ApplicationUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n\r\n                </div>\r\n\r\n                <div class=\"col-5 text-right\">\r\n                    <label class=\"text-info\">");
#nullable restore
#line 38 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                                                         Write(Model.ServiceHeader[0].Car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label><br />\r\n                    <label class=\"text-info\">");
#nullable restore
#line 39 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                        Write(Model.ServiceHeader[0].Car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                </div>
                <div class=""col-1 text-center pt-3 text-white-50 "">
                    <i class=""fas fa-car fa-2x""></i>
                </div>
            </div>
            <div class=""card-body"">
                <table class=""table table-striped border"">
                    <tr class=""table-secondary"">
                        <th>
                            ");
#nullable restore
#line 49 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader[0].Miles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 52 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader[0].TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 55 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader[0].Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 58 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                       Write(Html.DisplayNameFor(m => Model.ServiceHeader[0].DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n\r\n                        <th>\r\n\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                     foreach (var item in Model.ServiceHeader)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.Miles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 72 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 78 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                           Write(Html.DisplayFor(m => item.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0805f71c663822618bb1aced873cb65856b74c1d14408", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-list-alt\"></i> Details\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 87 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 97 "C:\Users\sebi\source\repos\TuningCarParts\TuningCarParts\Pages\Services\History.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TuningCarParts.Pages.Services.HistoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TuningCarParts.Pages.Services.HistoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TuningCarParts.Pages.Services.HistoryModel>)PageContext?.ViewData;
        public TuningCarParts.Pages.Services.HistoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
