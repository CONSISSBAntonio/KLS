#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff3eb40c890ec8efcef0db7b59669a441f8f4fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_Operators_Index), @"mvc.1.0.view", @"/Views/Carriers/Operators/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff3eb40c890ec8efcef0db7b59669a441f8f4fa", @"/Views/Carriers/Operators/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Operators_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml"
  
    ViewData["Title"] = "Transportista|Operadores";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"data-content p-4 text-left\">\r\n    <div class=\"p-4\">\r\n        <div class=\"d-flex flex-nowrap\">\r\n            <div class=\"p-2\">\r\n                <div class=\"text-left d-flex p-2\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 301, "\"", 334, 2);
            WriteAttributeValue("", 308, "/Carriers/formCarriers/", 308, 23, true);
#nullable restore
#line 11 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml"
WriteAttributeValue("", 331, id, 331, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""material-icons icon-red"">arrow_back</div>
                    </a>
                    <div class=""text-uppercase poppins medium size-24 pl-2"">BIBLIOTECA DIGITAL</div>
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
                        <th>ID</th>
                        <th>Nombre</th>
                        <th>Numero Tel</th>
                        <th>Licencia</th>
                        <th># Licencia</th>
                        <th>IN");
            WriteLiteral(@"E</th>
                        <th>#INE</th>
                        <th>SS</th>
                        <th>IMSS</th>
                        <th>Estatus</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody id=""table-info""></tbody>
            </table>
        </div>

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
            WriteLiteral("  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff3eb40c890ec8efcef0db7b59669a441f8f4fa8340", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2693, "\"", 2701, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"" id=""nombre"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3029, "\"", 3037, 0);
                EndWriteAttribute();
                WriteLiteral(@">Numero de teléfono</label>
                                <input type=""number"" class=""form-control"" name=""NoTelefono"" id=""NoTelefono""  />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3388, "\"", 3396, 0);
                EndWriteAttribute();
                WriteLiteral(@">Licencia</label>
                                <input type=""file"" name=""Licencia"" id=""Licencia"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3776, "\"", 3784, 0);
                EndWriteAttribute();
                WriteLiteral(@"># Licencia</label>
                                <input type=""text"" class=""form-control"" name=""NoLicencia"" id=""NoLicencia"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4124, "\"", 4132, 0);
                EndWriteAttribute();
                WriteLiteral(@">INE</label>
                                <input type=""file"" name=""Ine"" id=""Ine"" />
                            </div>
                        </div>
                        
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4456, "\"", 4464, 0);
                EndWriteAttribute();
                WriteLiteral(@"># INE</label>
                                <input type=""text"" class=""form-control"" name=""NoIne"" id=""NoIne"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 4856, "\"", 4864, 0);
                EndWriteAttribute();
                WriteLiteral(@">Seguro Social</label>
                                <input type=""text"" class=""form-control"" name=""SeguroSocial"" id=""SeguroSocial"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 5211, "\"", 5219, 0);
                EndWriteAttribute();
                WriteLiteral(@">IMSS</label>
                                <input type=""text"" class=""form-control"" name=""Imss"" id=""Imss"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 5483, "\"", 5491, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control form-control-sm\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff3eb40c890ec8efcef0db7b59669a441f8f4fa13238", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff3eb40c890ec8efcef0db7b59669a441f8f4fa14494", async() => {
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

                    <button type=""submit"" class=""btn btn-dark guardar"" style=""width:20%;"" id=""btnAccion"">
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
        var dataOperators = [];
        $(window).ready(function () {
            loadTable();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                jsonData[""Id_Transportista""] = ");
#nullable restore
#line 149 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml"
                                          Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                if (parseInt($(""#idEditar"").val()) == 0) {
                    $.post(""/Carriers/Operators/setOperators/"", jsonData, function (res) {
                        $(""#idEditar"").val(res.id);
                        dToast(""success"", ""Registro guardado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""/Carriers/Operators/putOperators/"", jsonData, function (res) {
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de actualizar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
        ");
                WriteLiteral(@"        }
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
                    let indice = dataOperators.findIndex(service => service.id === idEditar);
                    $(""#nombre"").val(dataOperators[indice].nombre);
                    $(""#NoTelefono"").val(dataOperators[indice].noTelefono);
                    $(""#NoLicencia"").val(dataOperators[indice].noLicencia);
                    $(""#NoIne"").val(dataOperators[indice].noIne);
                    $(""#SeguroSocial"").val(dataOperators[indice].seguroSocial);
                    $(""#Imss"").val(dataOperators[indice].imss);
                    $('#estatus option[value=""' + dataOperators[indice].estatus + '""]').attr(""se");
                WriteLiteral(@"lected"", true);
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
            stable.destroy();
            $(""#table-info"").empty();
            $.get(""/Carriers/Operators/getOperators/"", { ""Id_Transportista"":");
#nullable restore
#line 200 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Operators\Index.cshtml"
                                                                       Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"}, function (res) {
                dataOperators = res;
                $.each(dataOperators, function (item, key) {
                    $(""#table-info"").append(`
                             <tr>
                                <td>${nCon(key.id)}</td>
                                <td>${nCon(key.nombre)}</td>
                                <td>${nCon(key.noTelefono)}</td>
                                <td>${nCon(key.noLicencia)}</td>
                                <td>--</td>
                                <td>${nCon(key.noIne)}</td>
                                <td>--</td>
                                <td>${nCon(key.seguroSocial)}</td>
                                <td>${nCon(key.imss)}</td>
                                <td>`+ statusTable(key.estatus) + `</td>
                                <td>
                                    <a href=""#"">
                                        <span class=""material-icons"" onclick=""showModal('EDITAR','Editar',${nCon(key.id)});"">
 ");
                WriteLiteral(@"                                           mode_edit
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
