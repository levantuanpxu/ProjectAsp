#pragma checksum "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78281d6113fc66677b7ab10281a74244d852f288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78281d6113fc66677b7ab10281a74244d852f288", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cad597a8ff2372cf58b4a59cbcb48bdfa16cb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- slider Area Start-->
    <div class=""slider-area position-relative"">
        <div class=""slider-active dot-style"">
            <!-- Single Slider -->
            <div class=""single-slider hero-overly slider-height slider-bg1 d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-10"">
                            <div class=""hero__caption"">
");
#nullable restore
#line 11 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                 foreach (var product in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h1 data-animation=\"fadeInUp\" data-delay=\".2s\">");
#nullable restore
#line 13 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                                                              Write(product.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 14 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                 foreach (var product in Model.Blogs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <P data-animation=\"fadeInUp\" data-delay=\".4s\">");
#nullable restore
#line 17 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                                                             Write(product.Short_content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </P>
                                    <!-- Hero-btn -->
                                    <div class=""hero__btn"">
                                        <a href=""#"" class=""hero-btn mb-10"" data-animation=""fadeInUp"" data-delay="".8s"">Join Us Now</a>
                                    </div>
");
#nullable restore
#line 22 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Single Slider -->
            <div class=""single-slider hero-overly slider-height slider-bg1 d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-10"">
                            <div class=""hero__caption"">
                                <h1 data-animation=""fadeInUp"" data-delay="".2s"">Environment</h1>
                                <P data-animation=""fadeInUp"" data-delay="".4s"">Provide us a green and healthy life<br> we need to protect </P>
                                <!-- Hero-btn -->
                                <div class=""hero__btn"">
                                    <a href=""industries.html"" class=""hero-btn mb-10"" data-animation=""fadeInUp"" data-delay="".8s"">Join Us Now</a>
                                </");
            WriteLiteral(@"div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Single Slider -->
            <div class=""single-slider hero-overly slider-height slider-bg1 d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-10"">
                            <div class=""hero__caption"">
                                <h1 data-animation=""fadeInUp"" data-delay="".2s"">Environment</h1>
                                <P data-animation=""fadeInUp"" data-delay="".4s"">Provide us a green and healthy life<br> we need to protect </P>
                                <!-- Hero-btn -->
                                <div class=""hero__btn"">
                                    <a href=""industries.html"" class=""hero-btn mb-10"" data-animation=""fadeInUp"" data-delay="".8s"">Join Us Now</a>
                                ");
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--? video_start -->
        <div class=""video-area d-flex align-items-center justify-content-center"">
            <div class=""video-wrap position-relative"">
                <div class=""video-icon"">
                    <a class=""popup-video btn-icon"" href=""https://www.youtube.com/watch?v=up68UAfH0d0""><i class=""fas fa-play""></i></a>
                </div>
            </div>
        </div>
        <!-- video_end -->

    </div>
    <!-- slider Area End-->
    <!--? Visit Our Tailor Start -->
    <div class=""visit-tailor-area fix"">
        <!--Right Contents  -->
        <div class=""tailor-offers""></div>
        <!-- left Contents -->
        <div class=""tailor-details"">
            <span>Our Mission</span>
            <h2>Our main goal is to protect animals</h2>
            <p>
                The automated process sta");
            WriteLiteral(@"rts as soon as
                your clothes go into the machine. Duis cursus, mi quis
                viverra ornare, eros dolor interdum nulla, ut commodo
                diam libero vitae erat. Aenean faucibus nibh et justo
                cursus id rutrum lorem imperdiet. Nunc ut sem vitae
                risus tristique posuere.
            </p>
            <p class=""pera-bottom"">
                Interdum nulla, ut commodo diam libero vitae erat.
                Aenean faucibus nibh et justo cursus id rutrum lorem
                imperdiet. Nunc ut sem vitae risus tristique posuere.
            </p>
            <div class=""footer-tittles"">
                <p>CEO, Consulto</p>
                <h2>Capcilena Hanry</h2>
            </div>
        </div>
    </div>
    <!-- Visit Our Tailor End -->
    <!--? Services Area Start -->
    <div class=""service-area section-padding30"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-6 c");
            WriteLiteral("ol-sm-11\">\r\n                    <div class=\"single-cat text-center mb-30\">\r\n                        <div class=\"cat-icon\">\r\n                            <img src=\"assets/img/gallery/services1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5595, "\"", 5601, 0);
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
                            <img src=""assets/img/gallery/services2.png""");
            BeginWriteAttribute("alt", " alt=\"", 6083, "\"", 6089, 0);
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
                            <img src=""assets/img/gallery/services3.png""");
            BeginWriteAttribute("alt", " alt=\"", 6569, "\"", 6575, 0);
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
    <!-- Services Area End -->
    <!--? About Area Start -->
    <section class=""support-company-area fix pt-10"">
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
                        impe");
            WriteLiteral(@"rdiet. Nunc ut sem vitae risus tristique posuere.
                    </p>
                    <a href=""#"" class=""border-btn"">Join Us Now</a>
                </div>
            </div>
            <div class=""right-content"">
                <!-- img -->
                <div class=""right-img"">
                    <img src=""assets/img/gallery/safe_in.png""");
            BeginWriteAttribute("alt", " alt=\"", 7962, "\"", 7968, 0);
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
    <!--? Our Cases Start -->
    <div class=""our-cases-area section-padding30"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-xl-10 col-lg-10 "">
                    <!-- Section Tittle -->
                    <div class=""section-tittle text-center mb-80"">
                        <h2>Every day 6,000 beavers perished</h2>
                        <p class=""pl-20 pr-20"">
                            Interdum nulla,");
            WriteLiteral(@" ut commodo diam libero vitae erat. Aenean faucibus nibh et justo
                            cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""single-cases mb-40"">
                        <div class=""cases-img"">
                            <img src=""assets/img/gallery/case1.png""");
            BeginWriteAttribute("alt", " alt=\"", 9527, "\"", 9533, 0);
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
  ");
            WriteLiteral(@"                          </div>
                            <!-- / progress -->
                            <div class=""prices"">
                                <p><span>47,589 of 74,574</span></p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""single-cases mb-40"">
                        <div class=""cases-img"">
                            <img src=""assets/img/gallery/case2.png""");
            BeginWriteAttribute("alt", " alt=\"", 11109, "\"", 11115, 0);
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
  ");
            WriteLiteral(@"                          </div>
                            <div class=""prices"">
                                <p><span>47,589 of 74,574</span></p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""single-cases"">
                        <div class=""cases-img"">
                            <img src=""assets/img/gallery/case3.png""");
            BeginWriteAttribute("alt", " alt=\"", 12636, "\"", 12642, 0);
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
  ");
            WriteLiteral(@"                          </div>
                            <div class=""prices"">
                                <p><span>47,589 of 74,574</span></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Our Cases End -->
    <!--? Blog Area Start -->
    <section class=""home-blog-area pb-padding"">
        <div class=""container"">
            <!-- Section Tittle -->
            <div class=""row justify-content-center"">
                <div class=""col-xl-8 col-lg-9 col-md-11"">
                    <div class=""section-tittle text-center mb-90"">
                        <h2>Latest news</h2>
                        <p>Interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo  cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
   ");
            WriteLiteral(@"             <div class=""col-xl-6 col-lg-6 col-md-6"">
                    <div class=""home-blog-single mb-30"">
                        <div class=""blog-img-cap"">
                            <div class=""blog-img"">
                                <img src=""assets/img/gallery/home-blog1.png""");
            BeginWriteAttribute("alt", " alt=\"", 14984, "\"", 14990, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-cap"">
                                <h3><a href=""blog_details.html"">Leverage agile frameworks to provide a robust synopsis</a></h3>
                                <p>The automated process starts as soon as  your clothes go into the machine. Duis cursus, mi quis viverra ornare.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-6 col-lg-6 col-md-6"">
                    <div class=""home-blog-single mb-30"">
                        <div class=""blog-img-cap"">
                            <div class=""blog-img"">
                                <img src=""assets/img/gallery/home-blog2.png""");
            BeginWriteAttribute("alt", " alt=\"", 15779, "\"", 15785, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""blog-cap"">
                                <h3><a href=""blog_details.html"">Leverage agile frameworks to provide a robust synopsis</a></h3>
                                <p>The automated process starts as soon as  your clothes go into the machine. Duis cursus, mi quis viverra ornare.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Blog Area End -->

");
            DefineSection("ScriptsValidate", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".filter-product-btn"").click(function () {
                let value = $(this).attr('data-filter');
                if (value == ""all"") {
                    $("".filter"").show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $("".filter"").filter('.' + value).show('3000');
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
