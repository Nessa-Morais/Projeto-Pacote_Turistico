#pragma checksum "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39ca34924eba12debc40e389d88494d41d1e204b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PacotesTuristicos_ListarPacote), @"mvc.1.0.view", @"/Views/PacotesTuristicos/ListarPacote.cshtml")]
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
#line 1 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\_ViewImports.cshtml"
using Atividade_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\_ViewImports.cshtml"
using Atividade_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ca34924eba12debc40e389d88494d41d1e204b", @"/Views/PacotesTuristicos/ListarPacote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d462a169bb18cfd2e5b15a2cccdd2b5e800796f", @"/Views/_ViewImports.cshtml")]
    public class Views_PacotesTuristicos_ListarPacote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
  
    ViewData["Title"] = "ListarPacks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Pacotes Turísticos cadastrados</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Origem</th>
            <th>Destino</th>
            <th>Atrativos</th>
            <th>Saida</th>
            <th>Retorno</th>
            <th>Usuario</th>
            <th>Operações</th>

        </tr>
    </thead>

");
#nullable restore
#line 25 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
     foreach (PacotesTuristicos P in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
           Write(P.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 877, 2);
            WriteAttributeValue("", 836, "/PacotesTuristicos/AlterarPacks?pct=", 836, 36, true);
#nullable restore
#line 37 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
WriteAttributeValue("", 872, P.Id, 872, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar | </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 913, "\"", 960, 2);
            WriteAttributeValue("", 920, "/PacotesTuristicos/ExcluirPacks?Id=", 920, 35, true);
#nullable restore
#line 38 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
WriteAttributeValue("", 955, P.Id, 955, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Vanessa\SENAC\UC 04\Atividade_2\Views\PacotesTuristicos\ListarPacote.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
