#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\TypesOfUnits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9836fb965b8ef255298db4b60100b0df4bce55f8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9836fb965b8ef255298db4b60100b0df4bce55f8", @"/Views/Catalogs/TypesOfUnits/Index.cshtml")]
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
    <div class=""text-left d-flex mb-3"">
        <a href=""/Catalogs"">
            <div class=""material-icons icon-red"">arrow_back</div>
        </a>
        <div class=""text-uppercase poppins medium size-24 pl-2"">TIPOS DE UNIDADES</div>
        <div style=""padding-left:10%;"">
            <button class=""btn btn-sm btn-dark"" onclick=""showModal('AGREGAR');"">
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
                    <th>Litros</th>
                    <th>Operador</th>
                    <th>Administrativo</th>
                    <th>Limite Peso</th>
          ");
            WriteLiteral(@"          <th>Limite Volumen</th>
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
            <div class=""modal-body text-left"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9836fb965b8ef255298db4b60100b0df4bce55f87302", async() => {
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3\">\r\n                            <div class=\"form-group\">\r\n                                <label");
                BeginWriteAttribute("class", " class=\"", 2237, "\"", 2245, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"" required />
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 2512, "\"", 2520, 0);
                EndWriteAttribute();
                WriteLiteral(">Dirección</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"ejes\"");
                BeginWriteAttribute("value", " value=\"", 2620, "\"", 2628, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 2757, "\"", 2765, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control\" name=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9836fb965b8ef255298db4b60100b0df4bce55f89017", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9836fb965b8ef255298db4b60100b0df4bce55f810272", async() => {
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
                BeginWriteAttribute("class", " class=\"", 3323, "\"", 3331, 0);
                EndWriteAttribute();
                WriteLiteral(">Comentarios</label>\r\n                                <input type=\"text\" class=\"form-control\" name=\"mantenimiento\"");
                BeginWriteAttribute("value", " value=\"", 3446, "\"", 3454, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3610, "\"", 3618, 0);
                EndWriteAttribute();
                WriteLiteral(">Correo</label>\r\n                            <input type=\"text\" class=\"form-control\" required name=\"llantas\"/>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 3845, "\"", 3853, 0);
                EndWriteAttribute();
                WriteLiteral(">Notas</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"litros\"");
                BeginWriteAttribute("value", " value=\"", 3951, "\"", 3959, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 4079, "\"", 4087, 0);
                EndWriteAttribute();
                WriteLiteral(">Notas</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"rendimiento\"");
                BeginWriteAttribute("value", " value=\"", 4190, "\"", 4198, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    
                    <h3>Límites</h3>
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4503, "\"", 4511, 0);
                EndWriteAttribute();
                WriteLiteral(">Peso</label>\r\n                                <input type=\"text\" class=\"form-control\" name=\"peso\"");
                BeginWriteAttribute("value", " value=\"", 4610, "\"", 4618, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 4774, "\"", 4782, 0);
                EndWriteAttribute();
                WriteLiteral(@">Volumen</label>
                            <input type=""text"" class=""form-control"" required name=""volumen""/>
                        </div>
                    </div>

                    <button type=""submit"" class=""btn btn-dark guardar"" style=""width:15%;"">
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
        $(document).ready(function () {
            loadTable();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                $.post(""TypesOfUnits/setUnidades"", jsonData, function (res) {
                    loadTable();
                    dToast(""success"", ""Se guardo el registro"", ""Registrado"");
                    $("".guardar"").attr(""disabled"", false);
                    $('#frmRegister').trigger(""reset"");
                }).fail(function (error) {
                    dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                    $("".guardar"").attr(""disabled"", false);
                });

            });
        });

        function showModal(titulo = ""Title"") {
            $(""#titulo-modal"").empty("""");
            $(""#titulo-modal"").html(titulo);
            $(""#modalDiv"").modal(""show"");
        }

        function loadTable() ");
                WriteLiteral(@"{
            var stable = $('.table-viajes').DataTable();
            stable.destroy();
            $(""#table-info"").empty();
            $.get(""TypesOfUnits/getUnidades"", function (res) {
                $.each(res, function (item, key) {
                    $(""#table-info"").append(`
                         <tr>
                            <td>${nCon(key.nombre)}</td>
                            <td>$12 km</td>
                            <td>$12km</td>
                            <td>$12km</td>
                            <td>$12km</td>
                            <td>$12km</td>
                            <td>$12km</td>
                            <td>--</td>
                            <td>2011/04/25</td>
                            <td>`+ statusTable(key.estatus) + `</td>
                            <td>
                                <span class=""material-icons"">
                                    mode_edit
                                </span>
                            </t");
                WriteLiteral(@"d>
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
