#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96789f6d8a3daf75a4a910bff2cbe8822061ee4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travels_Index), @"mvc.1.0.view", @"/Views/Travels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96789f6d8a3daf75a4a910bff2cbe8822061ee4f", @"/Views/Travels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Travels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<<<<<<< HEAD\r\n﻿\r\n");
#nullable restore
#line 3 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml"
  
    ViewData["Title"] = "Transportista|Rutas";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"data-content p-4 text-left\">\r\n    <div class=\"p-4\">\r\n        <div class=\"text-left d-flex mb-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 261, 2);
            WriteAttributeValue("", 230, "/Carriers/Routes/formRoutes/", 230, 28, true);
#nullable restore
#line 10 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml"
WriteAttributeValue("", 258, id, 258, 3, false);

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
            BeginWriteAttribute("href", " href=\"", 541, "\"", 579, 2);
            WriteAttributeValue("", 548, "/Carriers/Routes/formRoutes/", 548, 28, true);
#nullable restore
#line 15 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml"
WriteAttributeValue("", 576, id, 576, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n=======\r\n﻿");
#nullable restore
#line 17 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Travels\Index.cshtml"
   
    ViewData["Title"] = "Viajes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""data-content p-4 text-left"">
    <div class=""p-4"">
        <div class=""text-left d-flex mb-3"">
            <div class=""text-uppercase poppins medium size-24 pl-2"">Viajes</div>
            <div style=""padding-left:20%;"">
                <a class=""btn btn-sm btn-dark"" href=""/Travels/formTravels/0"">
>>>>>>> 7c04e26e72cefb59cea3dc73e5ad667b3f7a79a8
                    <span class=""material-icons"">
                        add
                    </span>
                </a>
            </div>
        </div>

        <div class=""p-4 shadow bg-white"">
<<<<<<< HEAD
            <table id=""table"" class=""table table-striped table-bordered display table-hover table-viajes"" width=""100%"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Origen</th>
                        <th>Destino</th>
                        <th>Costo</th>
=======
            <table id=""table"" class=""table table-striped table-bordered display table-hover");
            WriteLiteral(@" table-viajes text-uppercase"" width=""100%"">
                <thead>
                    <tr>
                        <th>ID Viaje</th>
                        <th>Cliente</th>
                        <th>Origen</th>
                        <th>Destino</th>
                        <th>Fecha Salida</th>
                        <th>Fecha Llegada</th>
>>>>>>> 7c04e26e72cefb59cea3dc73e5ad667b3f7a79a8
                        <th>Estatus</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody id=""table-info""></tbody>
            </table>
        </div>

    </div>
</div>
<<<<<<< HEAD
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(window).ready(function () {\r\n\r\n        });\r\n\r\n        function loadTable() {\r\n\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("=======\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
       $(document).ready(function (event) {
           //loadTable();
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
                                <span ");
                WriteLiteral(@"class=""material-icons"">
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
            WriteLiteral(">>>>>>> 7c04e26e72cefb59cea3dc73e5ad667b3f7a79a8\r\n");
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
