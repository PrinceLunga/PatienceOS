#pragma checksum "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50f4c4a609d75d0375b498fe71e191f25ca1902a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_AddItemToCart), @"mvc.1.0.view", @"/Views/Cart/AddItemToCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f4c4a609d75d0375b498fe71e191f25ca1902a", @"/Views/Cart/AddItemToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf6a69537ab73375ba150c87b2bfbba088278bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_AddItemToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcInterface.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
  
    ViewBag.Title = "Patience Online Shopping";
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f4c4a609d75d0375b498fe71e191f25ca1902a5518", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"" src=""http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"" src=""http://cdn.rawgit.com/elevateweb/elevatezoom/master/jquery.elevateZoom-3.0.8.min.js""></script>

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

<script type=""text/javascript"">
    document.write('<base href=""' + document.location + '"" />');
</script>
<style type=""text/css"">

    /* #####################################################################
    #
    #   Project       : POSS
    #   Author        : Prince Thabane Lunga
    #   Version       : 1.0
    #   Created       : 30/05/2020
    #
    #
    ##################################################################### */
</style>

<link rel=""stylesheet");
            WriteLiteral(@""" href=""style.css"">
<link href=""http://www.professorcloud.com/styles/cloud-zoom.css"" rel=""stylesheet"" type=""text/css"">
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.13/angular.js""></script>
<script type=""text/JavaScript"" src=""http://www.professorcloud.com/js/cloud-zoom.1.0.2.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f4c4a609d75d0375b498fe71e191f25ca1902a8047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h3>Product Details</h3>\r\n\r\n\r\n<div ng-controller=\"MainCtrl\">\r\n\r\n\r\n");
#nullable restore
#line 46 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"panel panel-default\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f4c4a609d75d0375b498fe71e191f25ca1902a9497", async() => {
                WriteLiteral("\r\n                <div class=\"panel-heading\">");
#nullable restore
#line 50 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
                                      Write(x.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <div class=\"panel-body\">\r\n                    <div class=\"col-sm-3 col-md-6\" style=\"color:blue\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2117, "\"", 2166, 2);
                WriteAttributeValue("", 2124, "http://localhost:56829/ZoomImages/", 2124, 34, true);
#nullable restore
#line 53 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
WriteAttributeValue("", 2158, x.Image, 2158, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"cloud-zoom\" rel=\"adjustX: 10, adjustY:-4\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 2251, "\"", 2314, 2);
                WriteAttributeValue("", 2257, "data:image/jpeg;base64,", 2257, 23, true);
#nullable restore
#line 54 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
WriteAttributeValue("", 2280, Convert.ToBase64String(x.Image), 2280, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""400"" height=""400"" />
                        </a>

                    </div>
                    <div class=""col-sm-9 col-md-6"">
                        <h3><span id=""Category"" style=""color:black""><b>Category:</b></span></h3>

                        <h6><span id=""Group"" style=""color:black"">");
#nullable restore
#line 61 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
                                                            Write(x.Group);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h6>\r\n\r\n                        <h3><span id=\"Price\" style=\"color:black\"><b>Price:</b></span></h3>\r\n\r\n                        <h6><span id=\"Price\" style=\"color:black\">");
#nullable restore
#line 65 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
                                                            Write(x.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h6>\r\n\r\n                        <h3><span id=\"Department\" style=\"color:black\"><b>Department:</b></span></h3>\r\n                        <h4><span id=\"SubGroup\" style=\"color:black\">");
#nullable restore
#line 68 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
                                                               Write(x.SubGroup);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h4>\r\n                        <h3><span id=\"Discount\" style=\"color:black\"><b>Discount</b></span></h3>\r\n                        <h4><span id=\"Discount\" style=\"color:black\">");
#nullable restore
#line 70 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
                                                               Write(x.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h4>\r\n");
                WriteLiteral(@"                    </div>
                </div>


                <div>
                    <button type=""submit"" class=""btn btn-info btn-lg"" style=""margin-left:60px"">
                        <span class=""glyphicon glyphicon-shopping-cart""></span> Add To Cart
                    </button>

                    <a id=""btn_add""");
                BeginWriteAttribute("href", " href=\"", 3653, "\"", 3691, 1);
#nullable restore
#line 81 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
WriteAttributeValue("", 3660, Url.Action("Index", "Product"), 3660, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-info btn-lg"" style=""margin-left:60px"">
                        <span class=""glyphicon glyphicon-eye-open""></span> Continue shopping
                    </a>
                    <br />
                    <br />

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 90 "C:\Users\prince.lunga\Desktop\Prince\Projects\POSS_Backup\PatienceOS\MvcInterface\Views\Cart\AddItemToCart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcInterface.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
