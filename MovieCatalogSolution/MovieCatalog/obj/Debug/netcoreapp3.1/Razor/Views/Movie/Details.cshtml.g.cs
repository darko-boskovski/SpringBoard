#pragma checksum "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f0ad1b928e52c577868349a71278dcab4ae5948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
#line 1 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\_ViewImports.cshtml"
using MovieCatalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\_ViewImports.cshtml"
using MovieCatalog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\_ViewImports.cshtml"
using MovieCatalog.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0ad1b928e52c577868349a71278dcab4ae5948", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13404e702f0be79f231f3f1df97dcfc94cb4854f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
  
    string Genre = "";

    string Cast = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
 foreach (var member in @Model.Genre)
{
    Genre += member + ", ";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
 foreach (var member in @Model.Cast)
{
    Cast += member + ", ";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container body-content\">\r\n    <h1>Movie Details</h1>\r\n\r\n    <div class=\"products\">\r\n        <div class=\"thumbnail\">\r\n            <div class=\"half\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f0ad1b928e52c577868349a71278dcab4ae59484862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 448, "~/images/Movies/movie-", 448, 22, true);
#nullable restore
#line 28 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
AddHtmlAttributeValue("", 470, Model.Id, 470, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 481, ".jpg", 481, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3>");
#nullable restore
#line 31 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 32 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
              Write(Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 33 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
              Write(Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Release Date:</strong><br /> ");
#nullable restore
#line 34 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
                                                   Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Description:</strong><br /> ");
#nullable restore
#line 35 "C:\Users\Darko\Desktop\ASP.NET MVC  HomeWork\MovieCatalogSolution\MovieCatalog\Views\Movie\Details.cshtml"
                                                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
