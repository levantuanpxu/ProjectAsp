#pragma checksum "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cc6d0eac3813db0b81acb946514202a3e930f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Demo), @"mvc.1.0.view", @"/Views/Home/Demo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cc6d0eac3813db0b81acb946514202a3e930f8", @"/Views/Home/Demo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cad597a8ff2372cf58b4a59cbcb48bdfa16cb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Demo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <button class=\"btn btn-dark filter-product-btn\" data-filter=\"all\">All</button>\r\n");
#nullable restore
#line 6 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-dark filter-product-btn\" data-filter=\"");
#nullable restore
#line 8 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
                                                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 8 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
                                                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 9 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
         foreach (var item in Model.Blogs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 467, "\"", 523, 4);
            WriteAttributeValue("", 475, "col-md-6", 475, 8, true);
            WriteAttributeValue(" ", 483, "pb-4", 484, 5, true);
            WriteAttributeValue(" ", 488, "filter", 489, 7, true);
#nullable restore
#line 15 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
WriteAttributeValue(" ", 495, item.Category.CategoryName, 496, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card bg-white rounded shadow-sm\">\r\n                    <div class=\"card-body row\">\r\n                        <div class=\"col-7\"><label>");
#nullable restore
#line 18 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                        <div class=\"col-5\"><label>");
#nullable restore
#line 19 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
                                             Write(string.Format("{0:c0}", item.Short_content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                    </div>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 878, "\"", 898, 1);
#nullable restore
#line 21 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
WriteAttributeValue("", 884, item.ImageUrl, 884, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" class=""card-img-top img-fluid d-block mx-auto mb-3"" />
                    <div class=""card-body row"">
                        <div class=""col-12"">
                            <span class=""badge w-100"" style=""background-color: lawngreen"">");
#nullable restore
#line 24 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
                                                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\ProjectAsp\ProjectAsp\Demo1\Demo1\Views\Home\Demo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
