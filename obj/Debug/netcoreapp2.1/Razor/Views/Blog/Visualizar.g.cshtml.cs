#pragma checksum "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efe71c5984ceb6f2f2bd5d728d6c54c7a98af88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Visualizar), @"mvc.1.0.view", @"/Views/Blog/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Visualizar.cshtml", typeof(AspNetCore.Views_Blog_Visualizar))]
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
#line 1 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\_ViewImports.cshtml"
using ProjetoAdminSite;

#line default
#line hidden
#line 2 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\_ViewImports.cshtml"
using ProjetoAdminSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efe71c5984ceb6f2f2bd5d728d6c54c7a98af88", @"/Views/Blog/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c474944d16fba8e5d0c43dfaf821d71a9e67301", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoAdminSite.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating btn-small waves-effect waves-light orange darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
  
    ViewData["Title"] = "Detalhes de Blogs";

#line default
#line hidden
            BeginContext(92, 67, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s8\">\r\n        <h5>Título: ");
            EndContext();
            BeginContext(160, 12, false);
#line 9 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
               Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(172, 83, true);
            WriteLiteral("</h5>\r\n    </div>\r\n\r\n    <div class=\"col s2 right-align\">\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(255, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d8b31f6bba940f5adcc5b8cdb0109bf", async() => {
                BeginContext(336, 77, true);
                WriteLiteral("\r\n            <i class=\"material-icons left icones\">reply</i>Voltar\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 171, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col s12 m7\">\r\n        <div class=\"card\">\r\n            <div class=\"card-image\">\r\n                <img id=\"imagem\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 588, "\"", 620, 1);
#line 24 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
WriteAttributeValue("", 594, Url.Content(Model.Imagem), 594, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(621, 86, true);
            WriteLiteral(" alt=\"Imagem\" class=\"imagem-detalhe-blog\"/>\r\n                <span class=\"card-title\">");
            EndContext();
            BeginContext(708, 12, false);
#line 25 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
                                    Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(720, 110, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"card-content\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(831, 11, false);
#line 29 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
               Write(Model.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(842, 107, true);
            WriteLiteral("\r\n                </p>\r\n                <br>\r\n                <p class=\"right-align\">\r\n                    ");
            EndContext();
            BeginContext(950, 18, false);
#line 33 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
               Write(Model.DtPublicacao);

#line default
#line hidden
            EndContext();
            BeginContext(968, 48, true);
            WriteLiteral("\r\n                    <br>\r\n                    ");
            EndContext();
            BeginContext(1017, 18, false);
#line 35 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
               Write(Model.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 99, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"card-action\">\r\n                ");
            EndContext();
            BeginContext(1134, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70325077aed4179b40cd59b481bfb55", async() => {
                BeginContext(1273, 74, true);
                WriteLiteral("\r\n                    <i class=\"material-icons\">edit</i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\xampp\htdocs\ProjetoAdminSite\ProjetoAdminSite\Views\Blog\Visualizar.cshtml"
                                         WriteLiteral(Model.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1351, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoAdminSite.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
