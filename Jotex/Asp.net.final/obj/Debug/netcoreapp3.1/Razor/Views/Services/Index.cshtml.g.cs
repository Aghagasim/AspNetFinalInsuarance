#pragma checksum "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4625269ab679f559ab698437a401c1b345edb4d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Asp.net.final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Asp.net.final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Jotex.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4625269ab679f559ab698437a401c1b345edb4d9", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9172694c0b83dc7cdc8e32db3699f9c35f2de0", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Services</h2>
                        <ol class=""breadcrumb"">
                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4625269ab679f559ab698437a401c1b345edb4d94674", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li>Services</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start service-section -->
<section class=""service-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1"">
                <div class=""section-title-s2"">
                    <span>Our best services</span>
                    <h2>Best insurance services for our client’s</h2>
                </div>
            </div>
            <div class=""col col-xs-12"">
                <div class=""service-slider"">
");
#nullable restore
#line 36 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid\">\r\n                            <a href=\"#\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1513, "\"", 1531, 1);
#nullable restore
#line 40 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml"
WriteAttributeValue("", 1521, item.Icon, 1521, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                <h3>");
#nullable restore
#line 41 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Code Academy\source\repos\Jotex\Asp.net.final\Views\Services\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end service-section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
