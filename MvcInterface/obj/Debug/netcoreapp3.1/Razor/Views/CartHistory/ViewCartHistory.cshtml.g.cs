#pragma checksum "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506e7bfd0fac2dec0f731bb84e60b8cfa4daacee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartHistory_ViewCartHistory), @"mvc.1.0.view", @"/Views/CartHistory/ViewCartHistory.cshtml")]
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
#line 1 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506e7bfd0fac2dec0f731bb84e60b8cfa4daacee", @"/Views/CartHistory/ViewCartHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf6a69537ab73375ba150c87b2bfbba088278bf", @"/Views/_ViewImports.cshtml")]
    public class Views_CartHistory_ViewCartHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcInterface.Models.CartHistoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCartHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
  
    ViewData["Title"] = "ViewCartHistory";
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewCartHistory</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "506e7bfd0fac2dec0f731bb84e60b8cfa4daacee3923", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.CartHistoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.UserCartId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.DateRecorded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.CartHistoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserCartId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateRecorded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.ActionLink("Edit", "UpdateCartHistory", new { id=item.CartHistoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 66 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
           Write(Html.ActionLink("Delete", "DeleteCartHistory", new {  id=item.CartHistoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\MvcInterface\Views\CartHistory\ViewCartHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcInterface.Models.CartHistoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
