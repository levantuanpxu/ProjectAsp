#pragma checksum "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec53e44c351756429a7c027958e33e5a0cbf6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_projects), @"mvc.1.0.view", @"/Views/Home/projects.cshtml")]
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
#line 1 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\_ViewImports.cshtml"
using Demo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\_ViewImports.cshtml"
using Demo1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\_ViewImports.cshtml"
using Demo1.ViewsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\_ViewImports.cshtml"
using Demo1.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec53e44c351756429a7c027958e33e5a0cbf6bd", @"/Views/Home/projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cad597a8ff2372cf58b4a59cbcb48bdfa16cb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"  <!--? Hero Start -->
<div class=""slider-area2"">
    <div class=""slider-height2 d-flex align-items-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""hero-cap hero-cap2 pt-70"">
                        <h2>Projects</h2>
                        <nav aria-label=""breadcrumb"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec53e44c351756429a7c027958e33e5a0cbf6bd4792", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                <li class=""breadcrumb-item""><a href=""#"">Projects</a></li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Hero End -->
<!--? Our Cases Start -->
<div class=""our-cases-area section-padding30"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-10 col-lg-10 "">
                <!-- Section Tittle -->
                <div class=""section-tittle text-center mb-80"">
                    <h2>Every day 6,000 beavers perished</h2>
                    <p class=""pl-20 pr-20"">
                        Interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo
                        cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=");
            WriteLiteral("\"col-lg-4 col-md-6 col-sm-6\">\n                <div class=\"single-cases mb-40\">\n                    <div class=\"cases-img\">\n                        <img src=\"/assets/img/gallery/case1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1758, "\"", 1764, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cases-caption"">
                        <h3><a href=""#"">Wildlife in Danger</a></h3>
                        <p>
                            Interdum nulla, ut commodo diam libero vitae
                            erat. Aenean faucibus nibh et justo cursus
                            rutrum.
                        </p>
                        <!-- Progress Bar -->
                        <div class=""single-skill mb-15"">
                            <div class=""bar-progress"">
                                <div id=""bar1"" class=""barfiller"">
                                    <div class=""tipWrap"">
                                        <span class=""tip""></span>
                                    </div>
                                    <span class=""fill"" data-percentage=""70""></span>
                                </div>
                            </div>
                        </div>
                        <!-- / progress -->
                  ");
            WriteLiteral(@"      <div class=""prices"">
                            <p><span>47,589 of 74,574</span></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""single-cases mb-40"">
                    <div class=""cases-img"">
                        <img src=""/assets/img/gallery/case2.png""");
            BeginWriteAttribute("alt", " alt=\"", 3191, "\"", 3197, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cases-caption"">
                        <h3><a href=""#"">Our Green Projects</a></h3>
                        <p>
                            Interdum nulla, ut commodo diam libero vitae
                            erat. Aenean faucibus nibh et justo cursus
                            rutrum.
                        </p>
                        <!-- Progress Bar -->
                        <div class=""single-skill mb-15"">
                            <div class=""bar-progress"">
                                <div id=""bar2"" class=""barfiller"">
                                    <div class=""tipWrap"">
                                        <span class=""tip""></span>
                                    </div>
                                    <span class=""fill"" data-percentage=""25""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""prices"">
                 ");
            WriteLiteral(@"           <p><span>47,589 of 74,574</span></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""single-cases"">
                    <div class=""cases-img"">
                        <img src=""/assets/img/gallery/case3.png""");
            BeginWriteAttribute("alt", " alt=\"", 4574, "\"", 4580, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cases-caption"">
                        <h3><a href=""#"">Wildlife in Danger</a></h3>
                        <p>
                            Interdum nulla, ut commodo diam libero vitae
                            erat. Aenean faucibus nibh et justo cursus
                            rutrum.
                        </p>
                        <!-- Progress Bar -->
                        <div class=""single-skill mb-15"">
                            <div class=""bar-progress"">
                                <div id=""bar3"" class=""barfiller"">
                                    <div class=""tipWrap"">
                                        <span class=""tip""></span>
                                    </div>
                                    <span class=""fill"" data-percentage=""50""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""prices"">
                 ");
            WriteLiteral(@"           <p><span>47,589 of 74,574</span></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Our Cases End -->
<!--? About Area Start -->
<section class=""support-company-area fix "">
    <div class=""support-wrapper align-items-center"">
        <div class=""left-content"">
            <!-- section tittle -->
            <div class=""section-tittle section-tittle2 mb-30"">
                <span>Why You Should join us</span>
                <h2>A lot of animals need protection</h2>
            </div>
            <div class=""support-caption"">
                <p class=""pera-top"">
                    Interdum nulla, ut commodo diam libero vitae erat.
                    Aenean faucibus nibh et justo cursus id rutrum lorem
                    imperdiet. Nunc ut sem vitae risus tristique posuere.
                </p>
                <a href=""#"" class=""border-btn"">Join Us Now</a>
            </div>
        </div>
        <div class");
            WriteLiteral("=\"right-content\">\n            <!-- img -->\n            <div class=\"right-img\">\n                <img src=\"/assets/img/gallery/safe_in.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6766, "\"", 6772, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""support-img-cap text-center d-flex"">
                <div class=""single-one"">
                    <span>950</span>
                    <p>Poaching cases</p>
                </div>
                <div class=""single-two"">
                    <span>230</span>
                    <p>Volunteers worldwide</p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- About Area End -->
<!--? Services Area Start -->
<div class=""service-area section-padding30"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 col-sm-11"">
                <div class=""single-cat text-center mb-30"">
                    <div class=""cat-icon"">
                        <img src=""/assets/img/gallery/services1.png""");
            BeginWriteAttribute("alt", " alt=\"", 7580, "\"", 7586, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cat-cap"">
                        <h5><a href=""#"">Clean Water</a></h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-11"">
                <div class=""single-cat active text-center mb-30"">
                    <div class=""cat-icon"">
                        <img src=""/assets/img/gallery/services2.png""");
            BeginWriteAttribute("alt", " alt=\"", 8019, "\"", 8025, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cat-cap"">
                        <h5><a href=""#"">Renewable energy</a></h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-11"">
                <div class=""single-cat text-center mb-30"">
                    <div class=""cat-icon"">
                        <img src=""/assets/img/gallery/services3.png""");
            BeginWriteAttribute("alt", " alt=\"", 8456, "\"", 8462, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""cat-cap"">
                        <h5><a href=""#"">Protect animals</a></h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Services Area End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
