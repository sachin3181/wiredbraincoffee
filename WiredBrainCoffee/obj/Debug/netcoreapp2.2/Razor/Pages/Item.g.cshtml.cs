#pragma checksum "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8557b6629e421918345f49963cd11da16620b2a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WiredBrainCoffee.Pages.Pages_Item), @"mvc.1.0.razor-page", @"/Pages/Item.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Item.cshtml", typeof(WiredBrainCoffee.Pages.Pages_Item), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8557b6629e421918345f49963cd11da16620b2a4", @"/Pages/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca6ec018236db647dc4f1bc0a71ffdafa23720a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Item : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(73, 63, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"mt-4 mb-3\">\r\n        ");
            EndContext();
            BeginContext(137, 15, false);
#line 9 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml"
   Write(Model.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(152, 127, true);
            WriteLiteral("\r\n    </h1>\r\n    <hr />\r\n    <h3>A Taste of Autumn.</h3>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-8\">\r\n            ");
            EndContext();
            BeginContext(279, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8557b6629e421918345f49963cd11da16620b2a44476", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 315, "~/images/menu/", 315, 14, true);
#line 16 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml"
AddHtmlAttributeValue("", 329, Model.Item.ImageFile, 329, 21, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 116, true);
            WriteLiteral("\r\n            <hr>\r\n            <p>Available starting at 8:00 AM</p>\r\n            <hr>\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(476, 18, false);
#line 20 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml"
                       Write(Model.Item.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(494, 357, true);
            WriteLiteral(@"</p>
            <blockquote class=""blockquote"">
                <p class=""mb-0"">I feel at home every time I take a bite.</p>
                <footer class=""blockquote-footer"">
                    Actual customer
                    <cite title=""Source Title"">Happy Customer</cite>
                </footer>
            </blockquote>
            <p>");
            EndContext();
            BeginContext(852, 22, false);
#line 28 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Item.cshtml"
          Write(Model.Item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(874, 771, true);
            WriteLiteral(@"</p>
            <hr>
        </div>
        <div class=""col-md-4"">
            <div class=""card"">
                <h5 class=""card-header"">Nutrition Information</h5>
                <div class=""card-body"">
                    <p>Note: Nutrition information is an estimate only.  We back our goods fresh every day, so nutrition values may vary depending on preparation and serving size.</p>
                    <ul>
                        <li>Calories: 300</li>
                        <li>Total Fat: 25%</li>
                        <li>Saturated Fat: 15%</li>
                        <li>Fiber: 20%</li>
                        <li>Sugar: 25g</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ItemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ItemModel>)PageContext?.ViewData;
        public ItemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591