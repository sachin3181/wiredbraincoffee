#pragma checksum "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adadcf0e903b417669fc4f33cb29295e81121f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WiredBrainCoffee.Pages.Pages_Confirmation), @"mvc.1.0.razor-page", @"/Pages/Confirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Confirmation.cshtml", typeof(WiredBrainCoffee.Pages.Pages_Confirmation), null)]
namespace WiredBrainCoffee.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adadcf0e903b417669fc4f33cb29295e81121f72", @"/Pages/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4fe7d8a68c2883238bd751df3f1334211719a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
            BeginContext(104, 175, true);
            WriteLiteral("\r\n<div class=\"container contact-container\">\r\n    <h1 class=\"mt-4 mb-3\">\r\n        Thank you!\r\n        <small>It\'a always great to hear from you</small>\r\n    </h1>\r\n    <hr />\r\n");
            EndContext();
#line 13 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Confirmation.cshtml"
     if (!string.IsNullOrEmpty(Model.Message))
    {

#line default
#line hidden
            BeginContext(334, 12, true);
            WriteLiteral("        <h3>");
            EndContext();
            BeginContext(347, 13, false);
#line 15 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Confirmation.cshtml"
       Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(360, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 16 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Confirmation.cshtml"
    }

#line default
#line hidden
            BeginContext(374, 104, true);
            WriteLiteral("    <br />\r\n    <p>If you have any further questions, you can contact us at 555-123-1234</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WiredBrainCoffee.Pages.ConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WiredBrainCoffee.Pages.ConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WiredBrainCoffee.Pages.ConfirmationModel>)PageContext?.ViewData;
        public WiredBrainCoffee.Pages.ConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
