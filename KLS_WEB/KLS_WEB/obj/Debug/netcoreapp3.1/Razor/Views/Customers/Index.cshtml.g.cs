#pragma checksum "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6224e8eaa829de85e8b7a3ca0935e4a399712e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6224e8eaa829de85e8b7a3ca0935e4a399712e86", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""data-content p-4 text-left"">
    <div class=""p-4"">
        <div class=""text-left d-flex mb-3"">
            <div class=""text-uppercase poppins medium size-24 pl-2"">Clientes</div>
            <div style=""padding-left:20%;"">
                <a class=""btn btn-sm btn-dark"" href=""/Carriers/formCarriers/0"">
                    <span class=""material-icons"">
                        add
                    </span>
                </a>
            </div>
        </div>

        <div class=""p-4 shadow bg-white"">
            <table id=""table"" class=""table table-striped table-bordered display table-hover table-viajes"" width=""100%"">
                <thead>
                    <tr>
                        <th>NS</th>
                        <th>ID</th>
                        <th>Nombre Comercial</th>
                        <th>Nombre corto</th>
                        <th>Tamaño</th>
                        <th>Comentarios</th>
                        <th>Estatus</th>
                   ");
            WriteLiteral("     <th>Acciones</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"table-info\"></tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
       $(document).ready(function (event) {
           loadTable();
       });

       function loadTable() {
           var stable = $('.table-viajes').DataTable();
           stable.destroy();
           $(""#table-info"").empty();

           $.get(""Carriers/getCarriers"", function (res) {
               console.log(res);
               $.each(res, function (item, key) {
                   $(""#table-info"").append(`
                    <tr>
                        <td>${nCon(key.id)}</td>
                        <td>${nCon(key.id)}</td>
                        <td>${nCon(key.nombreComercial)}</td>
                        <td>${nCon(key.nombreComercial)}</td>
                        <td>${nCon(key.tamanio)}</td>
                        <td>${nCon(key.comentario)}</td>
                        <td>${statusTable(key.estatus)}</td>
                        <td>
                            <a href=""/Carriers/formCarriers/${nCon(key.id)}"">
                                <span cl");
                WriteLiteral(@"ass=""material-icons"">
                                    mode_edit
                                </span>
                            </a>
                        </td>
                    </tr>`);
               });
               dTable(""table-viajes"");
           }).fail(function (error, xhr, status) {
               dToast(""error"", ""Error al tratar de obtener los registros, intenta cerrar sesión y volver a iniciar."", ""Error"");
           });
       }
    </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
