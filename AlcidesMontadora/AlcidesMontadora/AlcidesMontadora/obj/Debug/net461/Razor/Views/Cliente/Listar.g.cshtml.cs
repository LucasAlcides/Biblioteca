#pragma checksum "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9518dd6ecc1edca917019a1cd04a0fe3e5e39d9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Listar), @"mvc.1.0.view", @"/Views/Cliente/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Listar.cshtml", typeof(AspNetCore.Views_Cliente_Listar))]
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
#line 1 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\_ViewImports.cshtml"
using AlcidesMontadora;

#line default
#line hidden
#line 2 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\_ViewImports.cshtml"
using AlcidesMontadora.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9518dd6ecc1edca917019a1cd04a0fe3e5e39d9a", @"/Views/Cliente/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fee9579d0ea7bccddaf6671b14306e7985cb241", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlcidesMontadora.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(97, 30, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b99c66c90954adb9e21f1b3c5abf34c", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 50, false);
#line 16 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 44, false);
#line 19 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 42, false);
#line 22 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 50, false);
#line 25 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.OrgaoExpedidor));

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(667, 38, false);
#line 28 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(705, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(761, 38, false);
#line 31 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(799, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(855, 39, false);
#line 34 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(894, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(950, 40, false);
#line 37 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(990, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1108, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1157, 49, false);
#line 46 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1262, 43, false);
#line 49 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1361, 41, false);
#line 52 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1458, 49, false);
#line 55 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrgaoExpedidor));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1563, 37, false);
#line 58 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1656, 37, false);
#line 61 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1749, 38, false);
#line 64 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1843, 39, false);
#line 67 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1938, 65, false);
#line 70 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2024, 71, false);
#line 71 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2116, 69, false);
#line 72 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Cliente\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(2224, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlcidesMontadora.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591