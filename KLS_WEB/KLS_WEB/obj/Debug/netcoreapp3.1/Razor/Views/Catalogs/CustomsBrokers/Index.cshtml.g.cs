#pragma checksum "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\Catalogs\CustomsBrokers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fa8223d13ef1a76971803910255cf8fbd4d6aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_CustomsBrokers_Index), @"mvc.1.0.view", @"/Views/Catalogs/CustomsBrokers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa8223d13ef1a76971803910255cf8fbd4d6aaf", @"/Views/Catalogs/CustomsBrokers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_CustomsBrokers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\Catalogs\CustomsBrokers\Index.cshtml"
  
    ViewData["Title"] = "kLS WEB";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""p-4"">
    <div class=""text-left d-flex mb-3"">
        <a href=""/Catalogs"">
            <div class=""material-icons icon-red"">arrow_back</div>
        </a>
        <div class=""text-uppercase poppins medium size-24 pl-2"">AGENTES ADUANALES</div>
        <div style=""padding-left:10%;"">
            <button class=""btn btn-sm btn-dark"" onclick=""showModal('AGREGAR','Agregar');"">
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
                    <th>Dirección</th>
                    <th>Telefonos</th>
                    <th>Departamento.</th>
                    <th>Contactos</th>
                    <th>Correo</th>
                    <th>Estatus</th>
      ");
            WriteLiteral(@"              <th>Notas</th>
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
            <div class=""modal-body text-left"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fa8223d13ef1a76971803910255cf8fbd4d6aaf7300", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2230, "\"", 2238, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"" id=""nombre"" required />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 2517, "\"", 2525, 0);
                EndWriteAttribute();
                WriteLiteral(">Dirección</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"direccion\" id=\"direccion\"");
                BeginWriteAttribute("value", " value=\"", 2645, "\"", 2653, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 2782, "\"", 2790, 0);
                EndWriteAttribute();
                WriteLiteral(">Telefonos</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"telefono\" id=\"telefono\"");
                BeginWriteAttribute("value", " value=\"", 2908, "\"", 2916, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3045, "\"", 3053, 0);
                EndWriteAttribute();
                WriteLiteral(">Departamentos</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"departamento\" id=\"departamento\"");
                BeginWriteAttribute("value", " value=\"", 3183, "\"", 3191, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3\">\r\n                            <div class=\"form-group\">\r\n                                <label");
                BeginWriteAttribute("class", " class=\"", 3445, "\"", 3453, 0);
                EndWriteAttribute();
                WriteLiteral(">Contactos</label>\r\n                                <input type=\"text\" class=\"form-control\" name=\"contacto\" id=\"contacto\"");
                BeginWriteAttribute("value", " value=\"", 3575, "\"", 3583, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3739, "\"", 3747, 0);
                EndWriteAttribute();
                WriteLiteral(">Correo</label>\r\n                            <input type=\"email\" class=\"form-control\" required");
                BeginWriteAttribute("value", " value=\"", 3842, "\"", 3850, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"correo\" id=\"correo\"/>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3995, "\"", 4003, 0);
                EndWriteAttribute();
                WriteLiteral(">Notas</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"notas\" id=\"notas\"/>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 4229, "\"", 4237, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control form-control-sm\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fa8223d13ef1a76971803910255cf8fbd4d6aaf12016", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fa8223d13ef1a76971803910255cf8fbd4d6aaf13272", async() => {
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
        var dataCustoms = [];

        $(document).ready(function () {
            loadTable();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));

                if (parseInt($(""#idEditar"").val()) != 0) {
                    $.post(""CustomsBrokers/putCustoms"", jsonData, function (res) {
                        console.log(res);
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""CustomsBrokers/setCustoms"", jsonData, function (res) {
                   ");
                WriteLiteral(@"     loadTable();
                        dToast(""success"", ""Se guardo el registro"", ""Registrado"");
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

            if (accion == ""Editar"") {
                try {
                    let indice = dataCustoms.findIndex(service => service.id === idEditar);
                    $(""#idEditar"").val(idEditar);
                    $(""#nombre"").val(dataCustoms[indice].no");
                WriteLiteral(@"mbre);
                    $(""#direccion"").val(dataCustoms[indice].direccion);
                    $(""#telefono"").val(dataCustoms[indice].telefono);
                    $(""#departamento"").val(dataCustoms[indice].departamento);
                    $(""#contacto"").val(dataCustoms[indice].contacto);
                    $(""#correo"").val(dataCustoms[indice].correo);
                    $(""#notas"").val(dataCustoms[indice].notas);

                    $('#estatus option[value=""' + dataCustoms[indice].estatus + '""]').attr(""selected"", true);
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
            var stable = $('.table-viajes').DataTable();
            stable.destroy(");
                WriteLiteral(@");
            $(""#table-info"").empty();
            $.get(""CustomsBrokers/getCustoms"", function (res) {
                dataCustoms = res;
                $.each(res, function (item, key) {
                    $(""#table-info"").append(`
                         <tr>
                            <td>${nCon(key.nombre)}</td>
                            <td>${nCon(key.direccion)}</td>
                            <td>${nCon(key.telefono)}</td>
                            <td>${nCon(key.departamento)}</td>
                            <td>${nCon(key.contacto)}</td>
                            <td>${nCon(key.correo)}</td>
                            <td>`+ statusTable(key.estatus) + `</td>
                            <td>
                                <a href=""#"" onclick=""showNota('${nCon(key.notas)}','NOTA');"">
                                    <h1>...</h1>
                                </a>
                            </td>
                            <td>
                                <");
                WriteLiteral(@"a href=""#"">
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
