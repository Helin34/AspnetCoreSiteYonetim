#pragma checksum "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94f69453cc0d6a49dbb84e527da85b7f09a68af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\_ViewImports.cshtml"
using SiteYonetim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\_ViewImports.cshtml"
using SiteYonetim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94f69453cc0d6a49dbb84e527da85b7f09a68af", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fdd112b4f49a606d92cc0d9f00387d7e582993", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h4>Kategoriler</h4>\r\n    <ul class=\"list-group single\">\r\n");
#nullable restore
#line 5 "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            ");
#nullable restore
#line 8 "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\Shared\Components\CategoryList\Default.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"badge badge-primary badge-pill\">14</span>\r\n            </li>\r\n");
#nullable restore
#line 11 "C:\Users\helin\source\repos\SiteYonetim\SiteYonetim\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
