#pragma checksum "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee3eaec21163fc01b643fd65e2f9baeed09d83b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_IndexTest), @"mvc.1.0.view", @"/Views/Cart/IndexTest.cshtml")]
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
#line 1 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\_ViewImports.cshtml"
using MvcInterface.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee3eaec21163fc01b643fd65e2f9baeed09d83b", @"/Views/Cart/IndexTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf6a69537ab73375ba150c87b2bfbba088278bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_IndexTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcInterface.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Charge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
  
    ViewData["Title"] = "IndexTest";
    Layout = "~/Views/Shared/_UserDashBoardcshtml.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee3eaec21163fc01b643fd65e2f9baeed09d83b5801", async() => {
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

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

<h1>Shopping Cart Items</h1>
");
#nullable restore
#line 19 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
  
    double sum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
<style type=""text/css"">
    .label {
        font-size: 10pt;
        font-weight: bold;
        font-family: Arial;
    }

    .contents {
        border: 1px dotted black;
        padding: 5px;
        width: 300px;
    }

    .name {
        color: #18B5F0;
    }

    .left {
        float: left;
        width: 50px;
        height: 50px;
    }

    .right {
        margin-left: 60px;
        line-height: 50px;
    }

    .clear {
        clear: both;
    }

    #footer {
        position: fixed;
        bottom: 0px;
        height: 3px;
        background-color: #666;
        color: #eee;
        width: 100%
    }
</style>
<script type=""text/javascript"">
    $(function () {
        ");
            WriteLiteral(@"$(""#btnPrint"").click(function () {
            var contents = $(""#dvContents"").html();
            var frame1 = $('<iframe />');
            frame1[0].name = ""frame1"";
            frame1.css({ ""position"": ""absolute"", ""top"": ""-1000000px"" });
            $(""body"").append(frame1);
            var frameDoc = frame1[0].contentWindow ? frame1[0].contentWindow : frame1[0].contentDocument.document ? frame1[0].contentDocument.document : frame1[0].contentDocument;
            frameDoc.document.open();
            //Create a new HTML document.
            frameDoc.document.write('<html><head><title>Patience Online Shopping Invoice</title>');
            frameDoc.document.write('</head><body>');
            //Append the external CSS file.
            frameDoc.document.write('<link href=""style.css"" rel=""stylesheet"" type=""text/css"" />');
            //Append the DIV contents.
            frameDoc.document.write(contents);
            frameDoc.document.write('</body></html>');
            frameDoc.document.c");
            WriteLiteral("lose();\r\n            setTimeout(function () {\r\n                window.frames[\"frame1\"].focus();\r\n                window.frames[\"frame1\"].print();\r\n                frame1.remove();\r\n            }, 500);\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n");
#nullable restore
#line 95 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
 if (Model.Any())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"dvContents\">\r\n\r\n        <table class=\"table table-hover\" width=\"100%\">\r\n            <thead>\r\n");
            WriteLiteral(@"                <tr>

                    <th>Category</th>
                    <th>Department</th>

                    <th>Image</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Remove</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 116 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 120 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                       Write(x.SubGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 121 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                       Write(x.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            <img id=\"img1\"");
            BeginWriteAttribute("src", " src=\"", 3742, "\"", 3805, 2);
            WriteAttributeValue("", 3748, "data:image/jpeg;base64,", 3748, 23, true);
#nullable restore
#line 124 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
WriteAttributeValue("", 3771, Convert.ToBase64String(x.Image), 3771, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"75\" />\r\n\r\n                        </td>\r\n                        <td>R ");
#nullable restore
#line 127 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                         Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 128 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                       Write(x.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee3eaec21163fc01b643fd65e2f9baeed09d83b12803", async() => {
                WriteLiteral("\r\n                                <span class=\"glyphicon btn-danger\"></span>Remove\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                                                                                   WriteLiteral(x.Id);

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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 137 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n");
#nullable restore
#line 142 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
             foreach (var x in Model)
            {
                sum = x.Total;

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tfoot>\r\n                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n\r\n                    <td><b>Total</b></td>\r\n                    <td>\r\n                        R ");
#nullable restore
#line 154 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                     Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n\r\n            </tfoot>\r\n\r\n        </table>\r\n\r\n\r\n");
            WriteLiteral(@"
    </div>
    <div>
        <table>
            <tr>

                <th>
                    <button type=""button"" id=""btnPrint"" class=""btn btn-primary"">Print</button>
                </th>
                <th>
                    <a id=""btn_add""");
            BeginWriteAttribute("href", " href=\"", 5194, "\"", 5232, 1);
#nullable restore
#line 174 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
WriteAttributeValue("", 5201, Url.Action("Index", "Product"), 5201, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\" style=\"margin-left:60px\">\r\n                        <span class=\"glyphicon glyphicon-eye-open\"></span> Continue shopping\r\n                    </a>\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee3eaec21163fc01b643fd65e2f9baeed09d83b17562", async() => {
                WriteLiteral("\r\n                        <label>Amount : R ");
#nullable restore
#line 181 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                                     Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <script src=\"//checkout.stripe.com/v3/checkout.js\"\r\n                                class=\"stripe-button\"\r\n                                data-key=\"");
#nullable restore
#line 184 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
                                     Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                data-description=\"Patience Online Shopping\"\r\n                                data-local=\"en\">\r\n                        </script>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 193 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"dvContents\">\r\n\r\n        <p><h4>You do not have any item on your Cart, click on continue shopping to add items</h4></p>\r\n        <button type=\"button\" id=\"btnPrint\" class=\"btn btn-primary\">Print</button>\r\n        <a id=\"btn_add\"");
            BeginWriteAttribute("href", " href=\"", 6317, "\"", 6355, 1);
#nullable restore
#line 201 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
WriteAttributeValue("", 6324, Url.Action("Index", "Product"), 6324, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-lg"" style=""margin-left:60px"">
            <span class=""glyphicon glyphicon-eye-open""></span> Continue shopping
        </a>

    </div>
    <script type=""text/javascript"">
        alert(""Looks like your cart is empty "");
    </script>
");
#nullable restore
#line 209 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\MvcInterface\Views\Cart\IndexTest.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<MvcInterface.Models.StripeSettings> Stripe { get; private set; }
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
