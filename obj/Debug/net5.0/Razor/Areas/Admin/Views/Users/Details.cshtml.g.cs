#pragma checksum "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884e6041c362240e55b31b107c373122a414f45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884e6041c362240e55b31b107c373122a414f45a", @"/Areas/Admin/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9fb3a2c0a8ab00f0e49b8e98098c6edfc749bf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eshop_srytr.Models.Identity.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>User</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 62 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 65 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 68 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 71 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 74 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 77 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 80 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 83 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 86 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 89 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 92 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 95 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 98 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 101 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 104 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 107 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "884e6041c362240e55b31b107c373122a414f45a15784", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 112 "/Users/jinambo/UNIVERSITY/www/semestral_project/Eshop_ASP-main 2/eshop_srytr/Areas/Admin/Views/Users/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "884e6041c362240e55b31b107c373122a414f45a17931", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eshop_srytr.Models.Identity.User> Html { get; private set; }
    }
}
#pragma warning restore 1591