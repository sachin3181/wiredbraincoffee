#pragma checksum "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Components\PopularBrews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be0c6ae0fa456838ee2359a9a5c981483ad8f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WiredBrainCoffee.Pages.Components.PopularBrews.Pages_Components_PopularBrews_Default), @"mvc.1.0.view", @"/Pages/Components/PopularBrews/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Components/PopularBrews/Default.cshtml", typeof(WiredBrainCoffee.Pages.Components.PopularBrews.Pages_Components_PopularBrews_Default))]
namespace WiredBrainCoffee.Pages.Components.PopularBrews
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\_ViewImports.cshtml"
using WiredBrainCoffee;

#line default
#line hidden
#line 2 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\_ViewImports.cshtml"
using WiredBrainCoffee.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be0c6ae0fa456838ee2359a9a5c981483ad8f10", @"/Pages/Components/PopularBrews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4fe7d8a68c2883238bd751df3f1334211719a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_PopularBrews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 100, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h2 class=\"card-title\">Popular Brews</h2>\r\n");
            EndContext();
#line 5 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Components\PopularBrews\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(179, 72, true);
            WriteLiteral("            <div>\r\n                <span class=\"card-text text-success\">");
            EndContext();
            BeginContext(252, 9, false);
#line 8 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Components\PopularBrews\Default.cshtml"
                                                Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(261, 27, true);
            WriteLiteral("</span>\r\n                - ");
            EndContext();
            BeginContext(289, 12, false);
#line 9 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Components\PopularBrews\Default.cshtml"
             Write(item.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(301, 39, true);
            WriteLiteral("\r\n               \r\n            </div>\r\n");
            EndContext();
#line 12 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Components\PopularBrews\Default.cshtml"
        }       

#line default
#line hidden
            BeginContext(358, 120, true);
            WriteLiteral("    </div>\r\n    <div class=\"card-footer\">\r\n        <a href=\"#\" class=\"btn btn-success\">Full Menu</a>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
