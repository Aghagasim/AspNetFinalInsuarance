#pragma checksum "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1eb964dca17db9d7bd9df9a9e57a1e4be6026d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Details), @"mvc.1.0.view", @"/Views/Services/Details.cshtml")]
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
#line 1 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Asp.net.final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Asp.net.final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\_ViewImports.cshtml"
using Jotex.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1eb964dca17db9d7bd9df9a9e57a1e4be6026d", @"/Views/Services/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9172694c0b83dc7cdc8e32db3699f9c35f2de0", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Service single</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Service single</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start service-single-section -->
<section class=""service-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""service-single-tab"">
                    <ul class=""nav tab-links clearfix"">
");
#nullable restore
#line 32 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                         foreach (var item in Model.Services.Take(6))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 1187, "\"", 1226, 1);
#nullable restore
#line 34 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
WriteAttributeValue("", 1195, item.Id == 1 ? "active" : "", 1195, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1283, 2);
            WriteAttributeValue("", 1271, "#0", 1271, 2, true);
#nullable restore
#line 35 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
WriteAttributeValue("", 1273, item.Id, 1273, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 1343, "\"", 1361, 1);
#nullable restore
#line 36 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
WriteAttributeValue("", 1351, item.Icon, 1351, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    <h3>");
#nullable restore
#line 37 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 40 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 44 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                         foreach (var item in Model.Services.Take(6))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1733, "\"", 1783, 3);
            WriteAttributeValue("", 1741, "tab-pane", 1741, 8, true);
            WriteAttributeValue(" ", 1749, "fade", 1750, 5, true);
#nullable restore
#line 46 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
WriteAttributeValue(" ", 1754, item.Id==1?"in active":"", 1755, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1784, "\"", 1800, 2);
            WriteAttributeValue("", 1789, "0", 1789, 1, true);
#nullable restore
#line 46 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
WriteAttributeValue("", 1790, item.Id, 1790, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"content-area clearfix\">\r\n                                    <div class=\"grid info-grid\">\r\n                                        <h3>");
#nullable restore
#line 49 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        ");
#nullable restore
#line 50 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
                                   Write(Html.Raw(item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"grid\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c1eb964dca17db9d7bd9df9a9e57a1e4be6026d9474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2216, "~/assets/images/", 2216, 16, true);
#nullable restore
#line 53 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"
AddHtmlAttributeValue("", 2232, item.Photo, 2232, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""bottom-info"">
                                    <div class=""text"">
                                        <h4>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</h4>
                                        <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                                    </div>
                                    <div class=""pdf-dwn-area"">
                                        <a href=""#"">
                                            <i class=""ti-recei");
            WriteLiteral(@"pt""></i>
                                            <h5>General Insurance Conditions</h5>
                                            <p>Document size: 34kb</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""features-grid clearfix"">
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-house""></i>
                                        </div>
                                        <h3>House protected</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-umbrella-1""></i>
                               ");
            WriteLiteral(@"         </div>
                                        <h3>Helth protected</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-cost""></i>
                                        </div>
                                        <h3>Small Premium</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 93 "C:\Users\Code Academy\Desktop\AspNetFinalInsuarance\Jotex\Asp.net.final\Views\Services\Details.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end service-single-section -->
<!-- start testimonials-section-s2 -->
<section class=""testimonials-section-s2 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""section-title"">
                    <span>Testimonials</span>
                    <h2>What People Says About Us</h2>
                </div>

                <div class=""testimonials-s2-nav"">
                    <div class=""slider-s2-arrows"">
                        <div class=""slider-prev""><i class=""fi flaticon-left-arrow-angle-big-gross-symbol""></i></div>
                        <div class=""slider-next""><i class=""fi flaticon-arrow-angle-pointing-to-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""testimonials-s");
            WriteLiteral(@"lider-holder"">
                    <div class=""testimonials-slider-s2"">
                        <div class=""testimonials-slider-item"">
                            <div class=""grid"">
                                <p>Recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer</p>
                                <div class=""quoter"">
                                    <h4>Mr. Bang</h4>
                                    <span>Life insurance holder</span>
                                </div>
                            </div>
                        </div>
                        <div class=""testimonials-slider-item"">
                            <div class=""grid"">
                                <p>Recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and");
            WriteLiteral(@" fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer</p>
                                <div class=""quoter"">
                                    <h4>Mr. Bang</h4>
                                    <span>Life insurance holder</span>
                                </div>
                            </div>
                        </div>
                        <div class=""testimonials-slider-item"">
                            <div class=""grid"">
                                <p>Recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer</p>
                                <div class=""quoter"">
                                    <h4>Mr. Bang</h4>
                                    <span>Life insurance holder</span>
                                </div>
           ");
            WriteLiteral(@"                 </div>
                        </div>
                        <div class=""testimonials-slider-item"">
                            <div class=""grid"">
                                <p>Recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer</p>
                                <div class=""quoter"">
                                    <h4>Mr. Bang</h4>
                                    <span>Life insurance holder</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end testimonials-section-s2 -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
