#pragma checksum "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcd9372c551adde2244169f784f7bf4f45ab9e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peca_Listar), @"mvc.1.0.view", @"/Views/Peca/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peca/Listar.cshtml", typeof(AspNetCore.Views_Peca_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcd9372c551adde2244169f784f7bf4f45ab9e2", @"/Views/Peca/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fee9579d0ea7bccddaf6671b14306e7985cb241", @"/Views/_ViewImports.cshtml")]
    public class Views_Peca_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlcidesMontadora.Models.Peca>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(94, 30, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a862618e83b24311b409e7afca8db42c", async() => {
                BeginContext(145, 10, true);
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
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 50, false);
#line 16 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFabricacao));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 45, false);
#line 19 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 47, false);
#line 22 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroSerie));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 42, false);
#line 25 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.PecaId));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 41, false);
#line 28 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(701, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(819, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(868, 49, false);
#line 37 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataFabricacao));

#line default
#line hidden
            EndContext();
            BeginContext(917, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(973, 44, false);
#line 40 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1073, 46, false);
#line 43 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroSerie));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1175, 41, false);
#line 46 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.PecaId));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1272, 40, false);
#line 49 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1368, 69, false);
#line 52 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.ActionLink("Update", "Update", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1458, 69, false);
#line 53 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "E:\Projetos\Faculdade\WebAvançada\Biblioteca\AlcidesMontadora\AlcidesMontadora\AlcidesMontadora\Views\Peca\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(1566, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlcidesMontadora.Models.Peca>> Html { get; private set; }
    }
}
#pragma warning restore 1591
