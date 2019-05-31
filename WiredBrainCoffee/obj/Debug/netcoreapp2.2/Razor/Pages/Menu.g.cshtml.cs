#pragma checksum "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b45d56cb267931a927f2d5d7c4b00deccfa2434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WiredBrainCoffee.Pages.Pages_Menu), @"mvc.1.0.razor-page", @"/Pages/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Menu.cshtml", typeof(WiredBrainCoffee.Pages.Pages_Menu), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b45d56cb267931a927f2d5d7c4b00deccfa2434", @"/Pages/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4fe7d8a68c2883238bd751df3f1334211719a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(66, 378, true);
            WriteLiteral(@"
<div class=""container"">
    <h1 class=""mt-4 mb-3"">
        Our Menu
    </h1>
    <hr />
    <h3>Brain food, comfort food..we have it all.</h3>

    <p>Our coffee is imported from fair trade establishments throughout the world.  Our food is made with all natural ingredients and sourced from local farms.  We're committed to sustainability!</p>
    <div class=""row"">
");
            EndContext();
#line 16 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
         foreach (var menuItem in Model.Menu)
        {

#line default
#line hidden
            BeginContext(502, 138, true);
            WriteLiteral("            <div class=\"col-lg-4 col-sm-6 portfolio-item\">\r\n                <div class=\"card h-100\">\r\n                    <a href=\"/item\">");
            EndContext();
            BeginContext(640, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b45d56cb267931a927f2d5d7c4b00deccfa24345692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
#line 20 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/menu/");
#line 20 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
                                                                                               WriteLiteral(menuItem.ImageFile);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(739, 159, true);
            WriteLiteral("</a>\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">\r\n                            <a class=\"color-main\" href=\"#\">");
            EndContext();
            BeginContext(899, 13, false);
#line 23 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
                                                      Write(menuItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(912, 82, true);
            WriteLiteral("</a>\r\n                        </h4>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(995, 16, false);
#line 25 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
                                        Write(menuItem.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 105, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        ");
            EndContext();
            BeginContext(1116, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b45d56cb267931a927f2d5d7c4b00deccfa24349365", async() => {
                BeginContext(1197, 19, true);
                WriteLiteral("Details & Nutrition");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
                                               WriteLiteral(menuItem.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1220, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 32 "D:\WiredBrainCoffee\WiredBrainCoffee\Pages\Menu.cshtml"
        }

#line default
#line hidden
            BeginContext(1305, 851, true);
            WriteLiteral(@"    </div>
    <ul class=""pagination justify-content-center"">
        <li class=""page-item"">
            <a class=""page-link"" href=""#"" aria-label=""Previous"">
                <span aria-hidden=""true"">&laquo;</span>
                <span class=""sr-only"">Previous</span>
            </a>
        </li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"">1</a>
        </li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"">2</a>
        </li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"">3</a>
        </li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"" aria-label=""Next"">
                <span aria-hidden=""true"">&raquo;</span>
                <span class=""sr-only"">Next</span>
            </a>
        </li>
    </ul>
</div>

");
            EndContext();
            DefineSection("FooterThird", async() => {
                BeginContext(2178, 205, true);
                WriteLiteral("\r\n    <p><a class=\"text-white\" href=\"#\">Allergen Information</a></p>\r\n    <p><a class=\"text-white\" href=\"#\">Ingredient Information</a></p>\r\n    <p><a class=\"text-white\" href=\"#\">Our food partners</a></p>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MenuModel>)PageContext?.ViewData;
        public MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
