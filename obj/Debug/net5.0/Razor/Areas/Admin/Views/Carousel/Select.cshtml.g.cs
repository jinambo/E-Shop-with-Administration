#pragma checksum "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea208582032c30fa3656eebbd4d548170eb64071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Carousel_Select), @"mvc.1.0.view", @"/Areas/Admin/Views/Carousel/Select.cshtml")]
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
#line 1 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/_ViewImports.cshtml"
using eshop_srytr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/_ViewImports.cshtml"
using eshop_srytr.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/_ViewImports.cshtml"
using eshop_srytr.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/_ViewImports.cshtml"
using eshop_srytr.Models.Database.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea208582032c30fa3656eebbd4d548170eb64071", @"/Areas/Admin/Views/Carousel/Select.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9fb3a2c0a8ab00f0e49b8e98098c6edfc749bf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Carousel_Select : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CarouselItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirmDelete();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/alerts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
  
    ViewData["Title"] = "Carousel items";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Carousel items admin page.</p>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea208582032c30fa3656eebbd4d548170eb640715998", async() => {
                WriteLiteral("Creata new item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 13 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
  
    if (Model != null || Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Source</th>
                <th scope=""col"">Image alt</th>
                <th scope=""col"">Edit</th>
                <th scope=""col"">Delete</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 28 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
              
                for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 32 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                                   Write(Model[i].ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <td>");
#nullable restore
#line 33 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                       Write(Model[i].ImageSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 34 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                       Write(Model[i].ImageAlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea208582032c30fa3656eebbd4d548170eb640719069", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                                                   WriteLiteral(Model[i].ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea208582032c30fa3656eebbd4d548170eb6407111270", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                                                     WriteLiteral(Model[i].ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 38 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 42 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Empty</p>\n");
#nullable restore
#line 44 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Carousel/Select.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea208582032c30fa3656eebbd4d548170eb6407114429", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CarouselItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591