#pragma checksum "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305a4ee2a4d05f93e8c9b52be972a72d7af2bb36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\_ViewImports.cshtml"
using MaquinaCafeVirtual;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\_ViewImports.cshtml"
using MaquinaCafeVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305a4ee2a4d05f93e8c9b52be972a72d7af2bb36", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4836dbee24682402736559a6ea8d0bc0ad94658f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaquinaCafeVirtual.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("BuscarValorBebida();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\" style=\"margin-top:110px;\"><b>BEM-VINDO(A)!</b></h1>\r\n    <h6 class=\"display-4\">Selecione a bebida desejada:</h6>\r\n    <div class=\"form-group\" style=\"display: inline-block;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305a4ee2a4d05f93e8c9b52be972a72d7af2bb364340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdutoId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 11 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ProdutoId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\" style=\"display:grid; align-content:center\">\r\n        <div>\r\n            <span id=\"valorBebida\"></span>\r\n        </div>\r\n        <div><input type=\"text\" name=\"valorMoedas\" id=\"valorMoedas\"");
            BeginWriteAttribute("value", " value=\"", 675, "\"", 683, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""INSIRA AS MOEDAS"" disabled=""disabled"" style=""text-align:center"" /></div>
        <div>
            <span style=""color:red"" id=""msgErro""></span>
            <span style=""color:lawngreen"" id=""msgSucesso""></span>
        </div>
        <div>
            <span>Moedas:</span>
            <br />
");
#nullable restore
#line 25 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Moedas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span type=\"submit\" class=\"dot\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1110, "\"", 1145, 3);
            WriteAttributeValue("", 1120, "InserirMoeda(", 1120, 13, true);
#nullable restore
#line 27 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
WriteAttributeValue("", 1133, item.Valor, 1133, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1144, ")", 1144, 1, true);
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 27 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
                                                                                  Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n");
#nullable restore
#line 28 "C:\Users\Wilson\Desktop\MaquinaCafeVirtual\MaquinaCafeVirtual\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div style=\"margin-top:1%\">\r\n            <button id=\"btnComprar\" onclick=\"Comprar()\" disabled=\"disabled\" type=\"button\" class=\"btn btn-secondary\">COMPRAR</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaquinaCafeVirtual.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
