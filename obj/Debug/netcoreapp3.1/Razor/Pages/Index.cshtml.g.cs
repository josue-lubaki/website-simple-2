#pragma checksum "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82c890090f605faf8ffad2181980267f3f6a266c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication5.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication5.Pages
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
#line 1 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c890090f605faf8ffad2181980267f3f6a266c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c224bf6eb62b3b851c8a1cfd65be5c5065f8334", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/YouTube/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Personnel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
  
    ViewData["Title"] = "Accueil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82c890090f605faf8ffad2181980267f3f6a266c3650", async() => {
                WriteLiteral("Films");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82c890090f605faf8ffad2181980267f3f6a266c4825", async() => {
                WriteLiteral("Personnel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <div id=\"carouselExampleControls_1\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 19 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
              
                var first = true;

            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Repas avec de la viande</h2>\r\n");
#nullable restore
#line 24 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
             foreach (var item in Model.Recipe)
            {

                if (item.Categorie == 1)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 609, "\"", 675, 2);
            WriteAttributeValue("", 617, "carousel-item", 617, 13, true);
#nullable restore
#line 30 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue(" ", 630, first ? Html.Raw("active") : Html.Raw(""), 631, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 729, "\"", 746, 1);
#nullable restore
#line 31 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 735, item.Image, 735, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 747, "\"", 763, 1);
#nullable restore
#line 31 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 753, item.Name, 753, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-caption\">\r\n                            <h3>");
#nullable restore
#line 33 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 34 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                    first = false;
                }


            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls_1"" role=""button""
           data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls_1"" role=""button""
           data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<br />
<div class=""text-center"">
    <div id=""carouselExampleControls_2"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
");
#nullable restore
#line 60 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
              
                
                first = true;

            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Les Mets Végétariens</h2>\r\n");
#nullable restore
#line 66 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
             foreach (var item in Model.Recipe)
            {

                if (item.Categorie == 2)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2065, "\"", 2131, 2);
            WriteAttributeValue("", 2073, "carousel-item", 2073, 13, true);
#nullable restore
#line 72 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue(" ", 2086, first ? Html.Raw("active") : Html.Raw(""), 2087, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 2185, "\"", 2202, 1);
#nullable restore
#line 73 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 2191, item.Image, 2191, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2203, "\"", 2219, 1);
#nullable restore
#line 73 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 2209, item.Name, 2209, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-caption\">\r\n                            <h3>");
#nullable restore
#line 75 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 76 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 80 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                    first = false;
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls_2"" role=""button""
           data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls_2"" role=""button""
           data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<br />
<div class=""text-center"">
    <div id=""carouselExampleControls_3"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
");
#nullable restore
#line 101 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
              
                first = true;
               
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>MalBouffes</h2>\r\n");
#nullable restore
#line 106 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
             foreach (var item in Model.Recipe)
            {

                if (item.Categorie == 3)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 3506, "\"", 3572, 2);
            WriteAttributeValue("", 3514, "carousel-item", 3514, 13, true);
#nullable restore
#line 112 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue(" ", 3527, first ? Html.Raw("active") : Html.Raw(""), 3528, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 3626, "\"", 3643, 1);
#nullable restore
#line 113 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 3632, item.Image, 3632, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3644, "\"", 3660, 1);
#nullable restore
#line 113 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
WriteAttributeValue("", 3650, item.Name, 3650, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-caption\">\r\n                            <h3>");
#nullable restore
#line 115 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 116 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 120 "C:\Users\MBIKAYI\Desktop\WebApplication5\Pages\Index.cshtml"
                    first = false;
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls_3"" role=""button""
           data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls_3"" role=""button""
           data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexRecipe> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexRecipe> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexRecipe>)PageContext?.ViewData;
        public IndexRecipe Model => ViewData.Model;
    }
}
#pragma warning restore 1591
