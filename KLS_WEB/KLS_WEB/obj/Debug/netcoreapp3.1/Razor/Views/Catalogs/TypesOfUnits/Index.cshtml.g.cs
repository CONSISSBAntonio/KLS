#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\TypesOfUnits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3cc99f7efff00cd6fe66e249ad861cc075ace3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_TypesOfUnits_Index), @"mvc.1.0.view", @"/Views/Catalogs/TypesOfUnits/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3cc99f7efff00cd6fe66e249ad861cc075ace3f", @"/Views/Catalogs/TypesOfUnits/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_TypesOfUnits_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\TypesOfUnits\Index.cshtml"
  
    ViewData["Title"] = "Tipos de unidades";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""p-4"">
    <div class=""d-flex flex-nowrap"">
        <div class=""p-2"">
            <div class=""text-left d-flex p-2"">
                <a href=""/Catalogs"">
                    <div class=""material-icons icon-red"">arrow_back</div>
                </a>
                <div class=""text-uppercase poppins medium size-24 pl-2"">TIPOS DE UNIDADES</div>
            </div>
        </div>

        <div class=""ml-auto p-2"">
            <button class=""btn btn-sm btn-secondary"" onclick=""showModal('AGREGAR','Agregar');"">
                <span class=""material-icons"">
                    add
                </span>
            </button>
        </div>
    </div>
    <div class=""p-4 shadow bg-white"">
        <table id=""table"" class=""table table-striped table-bordered display table-hover table-viajes"" width=""100%"">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Mantenimiento</th>
                    <th>Llantas</th>
                    <t");
            WriteLiteral(@"h>Litros</th>
                    <th>Operador</th>
                    <th>Administrativo</th>
                    <th>Limite Peso</th>
                    <th>Limite Volumen</th>
                    <th>Ejes</th>
                    <th>Estatus</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody id=""table-info""></tbody>
        </table>
    </div>
</div>

<!--Modal global-->
<div class=""modal fade"" id=""modalDiv"" tabindex=""-1"" role=""dialog"" data-backdrop=""static"" data-keyboard=""false"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""titulo-modal""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
      ");
            WriteLiteral("      <div class=\"modal-body text-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3cc99f7efff00cd6fe66e249ad861cc075ace3f7490", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2467, "\"", 2475, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"" id=""nombre"" required />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 2754, "\"", 2762, 0);
                EndWriteAttribute();
                WriteLiteral(">Ejes</label>\r\n                            <input type=\"number\" class=\"form-control\" name=\"ejes\" id=\"ejes\"");
                BeginWriteAttribute("value", " value=\"", 2869, "\"", 2877, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3006, "\"", 3014, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3cc99f7efff00cd6fe66e249ad861cc075ace3f9323", async() => {
                    WriteLiteral("Activo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3cc99f7efff00cd6fe66e249ad861cc075ace3f10578", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <h3>Costos por kilómetro</h3>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3585, "\"", 3593, 0);
                EndWriteAttribute();
                WriteLiteral(">Mantenimiento</label>\r\n                                <input type=\"number\" step=\"0.01\" class=\"form-control\" name=\"mantenimiento\" id=\"mantenimiento\"");
                BeginWriteAttribute("value", " value=\"", 3743, "\"", 3751, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3907, "\"", 3915, 0);
                EndWriteAttribute();
                WriteLiteral(">Llantas</label>\r\n                            <input type=\"number\" step=\"0.01\" class=\"form-control\" required name=\"llantas\" id=\"llantas\" />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 4171, "\"", 4179, 0);
                EndWriteAttribute();
                WriteLiteral(">Litros</label>\r\n                            <input type=\"number\" step=\"0.01\" class=\"form-control\" name=\"litros\" id=\"litros\"");
                BeginWriteAttribute("value", " value=\"", 4304, "\"", 4312, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 4432, "\"", 4440, 0);
                EndWriteAttribute();
                WriteLiteral(">Rendimiento</label>\r\n                            <input type=\"number\" step=\"0.01\" class=\"form-control\" name=\"rendimiento\" id=\"rendimiento\"");
                BeginWriteAttribute("value", " value=\"", 4580, "\"", 4588, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>

                    <h3>Límites</h3>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4873, "\"", 4881, 0);
                EndWriteAttribute();
                WriteLiteral(">Peso</label>\r\n                                <input type=\"number\" step=\"0.01\" class=\"form-control\" name=\"limite_peso\" id=\"limite_peso\"");
                BeginWriteAttribute("value", " value=\"", 5018, "\"", 5026, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 5182, "\"", 5190, 0);
                EndWriteAttribute();
                WriteLiteral(@">Volumen</label>
                            <input type=""text"" class=""form-control"" required name=""limite_volumen"" id=""limite_volumen"" />
                        </div>
                    </div>

                    <button type=""submit"" class=""btn btn-dark guardar"" style=""width:15%;"" id=""btnAccion"">
                        Guardar
                    </button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn\" data-dismiss=\"modal\">Cerrar</button>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--Modal global-->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var dataUnidades = [];

        $(document).ready(function () {
            loadTable();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                console.log(jsonData);
                if (parseInt($(""#idEditar"").val()) != 0) {
                    $.post(""TypesOfUnits/putUnidades"", jsonData, function (res) {
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""TypesOfUnits/setUnidades"", jsonData, function (res) {
                        l");
                WriteLiteral(@"oadTable();
                        dToast(""success"", ""Se guardó el registro"", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                        $('#frmRegister').trigger(""reset"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                }

            });
        });

        function showModal(titulo = ""Title"", accion, idEditar = 0) {
            $('#frmRegister').trigger(""reset"");
            $("".guardar"").html(accion);
            $(""#titulo-modal"").empty("""");
            $(""#titulo-modal"").html(titulo);
            $(""#idEditar"").val(idEditar);
            if (accion == ""Editar"") {
                try {
                    let indice = dataUnidades.findIndex(service => service.id === idEditar);
                    $(""#nombre"").val(dataUnidades[indice].nombre);
    ");
                WriteLiteral(@"                $(""#mantenimiento"").val(dataUnidades[indice].mantenimiento);
                    $(""#llantas"").val(dataUnidades[indice].llantas);                                                           
                    $(""#litros"").val(dataUnidades[indice].litros);
                    $(""#limite_peso"").val(dataUnidades[indice].limite_peso);
                    $(""#limite_volumen"").val(dataUnidades[indice].limite_volumen);
                    $(""#ejes"").val(dataUnidades[indice].ejes);
                    $('#estatus option[value=""' + dataUnidades[indice].estatus + '""]').attr(""selected"", true);
                    $(""#modalDiv"").modal(""show"");

                } catch (error) {
                    dToast(""error"", ""Error al tratar de editar, intenta recargar la página."", ""Error"");
                    $(""#modalDiv"").modal(""hide"");
                }
            } else {
                $(""#modalDiv"").modal(""show"");
            }
        }

        function loadTable() {
            var sta");
                WriteLiteral(@"ble = $('.table-viajes').DataTable();
            stable.destroy();
            $(""#table-info"").empty();
            $.get(""TypesOfUnits/getUnidades"", function (res) {
                dataUnidades = res;
                console.log(dataUnidades);
                $.each(res, function (item, key) {
                    $(""#table-info"").append(`
                         <tr>
                            <td>${nCon(key.nombre)}</td>
                            <td>${nCon(key.mantenimiento)}/Km</td>
                            <td>${nCon(key.llantas)}/Km</td>
                            <td>${nCon(key.litros)}/Km</td>
                            <td>Operador</td>
                            <td>Administrativo</td>
                            <td>${nCon(key.limite_peso)}/Km</td>
                            <td>${nCon(key.limite_volumen)}/Km</td>
                            <td>${nCon(key.ejes)}/Km</td>
                            <td>`+ statusTable(key.estatus) + `</td>
                           ");
                WriteLiteral(@" <td>
                                <a href=""#"">
                                    <span class=""material-icons"" onclick=""showModal('EDITAR','Editar',${nCon(key.id)});"">
                                        mode_edit
                                    </span>
                                </a>
                            </td>
                        </tr>`);
                });
                dTable(""table-viajes"");
            }).fail(function (error) {
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
