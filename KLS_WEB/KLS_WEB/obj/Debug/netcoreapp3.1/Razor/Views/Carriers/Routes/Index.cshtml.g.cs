#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3763a6f7e5ad626ccbf53fce52626ce0fd6b0eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_Routes_Index), @"mvc.1.0.view", @"/Views/Carriers/Routes/Index.cshtml")]
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
#line 1 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3763a6f7e5ad626ccbf53fce52626ce0fd6b0eaa", @"/Views/Carriers/Routes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Routes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml"
  
    ViewData["Title"] = "Transportista|Rutas";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"data-content p-4 text-left\">\r\n    <div class=\"p-4\">\r\n        <div class=\"text-left d-flex mb-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 208, "\"", 246, 2);
            WriteAttributeValue("", 215, "/Carriers/Routes/formRoutes/", 215, 28, true);
#nullable restore
#line 9 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml"
WriteAttributeValue("", 243, id, 243, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""material-icons icon-red"">arrow_back</div>
            </a>
            <div class=""text-uppercase poppins medium size-24 pl-2"">RUTAS TRANSPORTISTAS</div>
            <div style=""padding-left:10%;"">
                <a class=""btn btn-sm btn-dark""");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 564, 2);
            WriteAttributeValue("", 533, "/Carriers/Routes/formRoutes/", 533, 28, true);
#nullable restore
#line 14 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml"
WriteAttributeValue("", 561, id, 561, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
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
                        <th>ID</th>
                        <th>Origen</th>
                        <th>Destino</th>
                        <th>Costo</th>
                        <th>Estatus</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody id=""table-info""></tbody>
            </table>
        </div>

    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        var dataCiudad = [];
        var dataEstado = [];

        $(window).ready(function () {
            getCiudad();
            getEstado();
            loadTable();
        });

        function getCiudad() {
            $.get(""../../Catalogs/Geography/City/getCity"", function (res) {
                dataCiudad = res;
                console.log(res);
            });
        }

        function getEstado() {
            $.get(""../../Catalogs/Geography/State/getState"", function (res) {
                dataEstado = res;
            });
        }

        function loadTable() {
            var stable = $('.table-viajes').DataTable();
            stable.destroy();
            $(""#table-info"").empty();
            $.get(""/Carriers/Routes/getRoutesAll/"", function (res) {
                console.log(res);
                $.each(res, function (item, key) {

                     //let cOrigen = dataCiudad.findIndex(ciudad => ciudad.id === key.id_Ciudad_Origen);
   ");
                WriteLiteral(@"                  //let cDestino = dataCiudad.findIndex(ciudad => ciudad.id === key.id_Ciudad_Destino);
                     //let eOrigen = dataEstado.findIndex(estado => estado.id === key.id_Estado_Origen);
                     //let eDestino = dataEstado.findIndex(estado => estado.id === key.id_Estado_Estado); 

                    $(""#table-info"").append(`
                             <tr>
                                <td>${nCon(key.id)}</td>
                                <td>${dataEstado[0].nombre} - ${dataCiudad[0].nombre}</td>
                                <td>${dataEstado[0].nombre} - ${dataCiudad[0].nombre}</td>
                                <td>$$</td>
                                <td>${statusTable(key.estatus)}</td>
                                <td>
                                    <a href=""/Carriers/Routes/formRoutes/`+");
#nullable restore
#line 85 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Routes\Index.cshtml"
                                                                      Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"+`/${nCon(key.id)}"">
                                        <span class=""material-icons"">
                                            mode_edit
                                        </span>
                                    </a>
                                </td>
                            </tr>`);
                });
                dTable(""table-viajes"");
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
