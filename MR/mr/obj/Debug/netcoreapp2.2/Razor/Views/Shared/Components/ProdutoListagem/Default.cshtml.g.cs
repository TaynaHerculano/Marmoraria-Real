#pragma checksum "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710870f5ce5a9092baf9981d4ec4b96a69f428d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProdutoListagem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProdutoListagem/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProdutoListagem_Default))]
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
#line 3 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710870f5ce5a9092baf9981d4ec4b96a69f428d7", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407ce28c86f59f539e731c44ae658814bb6c6766", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProdutoListagem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoListagemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ordenacao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
  
    var pesquisa = Context.Request.Query["pesquisa"];
    var ordenacao = Context.Request.Query["ordenacao"].ToString();
    var action = ViewContext.RouteData.Values["action"].ToString();

#line default
#line hidden
#line 7 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
 if (Model.lista.Count > 0)
{

#line default
#line hidden
            BeginContext(264, 207, true);
            WriteLiteral("    <div class=\"container\" id=\"code_prod_complex\">\r\n        <div class=\"row\">\r\n            <div class=\"offset-md-10 col-md-2\">\r\n                <!-- Alfabetica, Menor Preço, Maior Preço -->\r\n                ");
            EndContext();
            BeginContext(471, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710870f5ce5a9092baf9981d4ec4b96a69f428d77613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ordenacao);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 13 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ordenacao;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(573, 65, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 17 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
             foreach (var produto in Model.lista)
            {

#line default
#line hidden
            BeginContext(704, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(720, 1511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710870f5ce5a9092baf9981d4ec4b96a69f428d710215", async() => {
                BeginContext(799, 158, true);
                WriteLiteral("\r\n                    <div class=\"col-md-3\">\r\n                        <figure class=\"card card-product\">\r\n                            <div class=\"img-wrap\">\r\n");
                EndContext();
#line 23 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                 if (produto.Imagens != null && produto.Imagens.Count() > 0)
                                {

#line default
#line hidden
                BeginContext(1086, 40, true);
                WriteLiteral("                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1126, "\"", 1169, 1);
#line 25 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
WriteAttributeValue("", 1132, produto.Imagens.ElementAt(0).Caminho, 1132, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1170, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 26 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1283, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1319, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "710870f5ce5a9092baf9981d4ec4b96a69f428d712090", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1357, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                }

#line default
#line hidden
                BeginContext(1394, 148, true);
                WriteLiteral("\r\n                            </div>\r\n                            <figcaption class=\"info-wrap\">\r\n                                <h4 class=\"title\">");
                EndContext();
                BeginContext(1543, 12, false);
#line 34 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                             Write(produto.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1555, 137, true);
                WriteLiteral("</h4>\r\n                            </figcaption>\r\n                            <div class=\"bottom-wrap\">\r\n                                ");
                EndContext();
                BeginContext(1692, 157, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710870f5ce5a9092baf9981d4ec4b96a69f428d714356", async() => {
                    BeginContext(1824, 21, true);
                    WriteLiteral("Adicionar ao Carrinho");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                                                                WriteLiteral(produto.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1849, 123, true);
                WriteLiteral("\r\n                                <div class=\"price-wrap h5\">\r\n                                    <span class=\"price-new\">");
                EndContext();
                BeginContext(1973, 27, false);
#line 39 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(2000, 227, true);
                WriteLiteral("</span>\r\n                                </div> <!-- price-wrap.// -->\r\n                            </div> <!-- bottom-wrap.// -->\r\n                        </figure>\r\n                    </div> <!-- col // -->\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                                      WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2248, 40, true);
            WriteLiteral("        </div> <!-- row.// -->\r\n        ");
            EndContext();
            BeginContext(2289, 143, false);
#line 47 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
   Write(Html.PagedListPager((IPagedList)Model.lista, pagina => Url.Action(action, new { pagina = pagina, pesquisa = pesquisa, ordenacao = ordenacao })));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2458, 190, true);
            WriteLiteral("    <div class=\"container\">\r\n        <br />\r\n        <div class=\"alert alert-info\">\r\n            <strong>Opsss!</strong> Não temos produtos para esta categoria!\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 58 "C:\Users\ttata\Desktop\Programação\Marmoraria-Real\MR\mr\Views\Shared\Components\ProdutoListagem\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoListagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
