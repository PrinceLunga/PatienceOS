#pragma checksum "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d925028f80f7194f506df61ab9772acf563687e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProduct), @"mvc.1.0.view", @"/Views/Product/GetProduct.cshtml")]
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
#line 1 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d925028f80f7194f506df61ab9772acf563687e", @"/Views/Product/GetProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf6a69537ab73375ba150c87b2bfbba088278bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcInterface.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
  
    ViewBag.Title = "Patience Online Shopping";
    Layout = "~/Views/Shared/_HomepageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Get Product by Id ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d925028f80f7194f506df61ab9772acf563687e4807", async() => {
                WriteLiteral("Back");
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
            WriteLiteral("</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d925028f80f7194f506df61ab9772acf563687e6048", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""id"">Id:</label>
        <input class=""form-control"" name=""id"" />
    </div>
    <div class=""text-center panel-body"">
        <button type=""submit"" class=""btn btn-sm btn-primary"">Get Product</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Product</h2>
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead><tr><th>ID</th><th>Name</th><th>Group</th> <th>Sub Group</th> <th>Status</th><th>Price</th><th>Quantity</th></tr></thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 26 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.SubGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
               Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 34 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
                      
                        var base64 = Convert.ToBase64String(Model.Image);
                        var imgsrc = String.Format("data:image/gif;base64,{0}", base64);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 1362, "\"", 1375, 1);
#nullable restore
#line 38 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
WriteAttributeValue("", 1368, imgsrc, 1368, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"300\" />\r\n\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 44 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Product\GetProduct.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcInterface.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
