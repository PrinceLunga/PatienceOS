<<<<<<< HEAD
#pragma checksum "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f159d2d66eebe3398726d4574492ced4b1b9d7"
=======
#pragma checksum "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f159d2d66eebe3398726d4574492ced4b1b9d7"
>>>>>>> origin/Read
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Login), @"mvc.1.0.view", @"/Views/Cart/Login.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\_ViewImports.cshtml"
>>>>>>> origin/Read
using POSSMvc;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\_ViewImports.cshtml"
>>>>>>> origin/Read
using POSSMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f159d2d66eebe3398726d4574492ced4b1b9d7", @"/Views/Cart/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5a96c3925d80e3ba5c675c5046a791c30da8c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSMvc.Models.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 3 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 3 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n\r\n<h4>LoginViewModel</h4>\r\n<div class=\"row\" >\r\n    <div class=\"col-md-6\">\r\n        <h1>External Login</h1>\r\n        <hr/>\r\n");
#nullable restore
<<<<<<< HEAD
#line 14 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 14 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
           
            if(Model.ExternalLogins.Count ==0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>No External Logins Configured</h1>\r\n");
#nullable restore
<<<<<<< HEAD
#line 18 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 18 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f159d2d66eebe3398726d4574492ced4b1b9d74914", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f159d2d66eebe3398726d4574492ced4b1b9d74860", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
                     foreach(var provider in Model.ExternalLogins)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 674, "\"", 696, 1);
#nullable restore
<<<<<<< HEAD
#line 24 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 24 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
WriteAttributeValue("", 682, provider.Name, 682, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                                title=\"", 697, "\"", 777, 5);
                WriteAttributeValue("", 738, "Login", 738, 5, true);
                WriteAttributeValue(" ", 743, "using", 744, 6, true);
                WriteAttributeValue(" ", 749, "your", 750, 5, true);
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 25 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
WriteAttributeValue(" ", 754, provider.Name, 755, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 769, "account", 770, 8, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                        </button>\r\n");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 28 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 21 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
                                                                WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 30 "C:\Users\prince.lunga\Desktop\Prince\Projects\2020\POSS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
=======
#line 30 "C:\Users\Nhlanhla Vilakazi\Desktop\Patience OS\PatienceOS\POSSMvc\Views\Cart\Login.cshtml"
>>>>>>> origin/Read
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSMvc.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
