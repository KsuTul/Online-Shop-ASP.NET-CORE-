#pragma checksum "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc6c8ca040ffcce7ec06c85ded1e0dc3e4fc9c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookGallery), @"mvc.1.0.view", @"/Views/Home/BookGallery.cshtml")]
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
#line 1 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\_ViewImports.cshtml"
using Online_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\_ViewImports.cshtml"
using Online_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc6c8ca040ffcce7ec06c85ded1e0dc3e4fc9c3", @"/Views/Home/BookGallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c341d60b42f081b259587877284be7fea141da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BookGallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
  
    //ViewData["Title"] = "BookGallery";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc6c8ca040ffcce7ec06c85ded1e0dc3e4fc9c33483", async() => {
                WriteLiteral("\r\n    <title>Hello ASP.NET</title>\r\n    <meta charset=\"utf-8\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc6c8ca040ffcce7ec06c85ded1e0dc3e4fc9c34519", async() => {
                WriteLiteral("\r\n    <h2>Find the book for you</h2>\r\n<table>\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>Author</td>\r\n        <td>Price</td>\r\n        <td></td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
     foreach (var b in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
           Write(b.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 24 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
             Write(b.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 25 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
             Write(b.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Ksushka\Source\Repos\Online-Shop\Online-Shop\Views\Home\BookGallery.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
