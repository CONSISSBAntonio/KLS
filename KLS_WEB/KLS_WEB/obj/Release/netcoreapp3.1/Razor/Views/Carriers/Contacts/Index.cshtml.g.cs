#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90998dd9a72901d56b2ab56c8054c25c197ad646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_Contacts_Index), @"mvc.1.0.view", @"/Views/Carriers/Contacts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90998dd9a72901d56b2ab56c8054c25c197ad646", @"/Views/Carriers/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Transportista|Contactos";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"data-content p-4 text-left\">\r\n    <div class=\"p-4\">\r\n        <div class=\"text-left d-flex mb-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 212, "\"", 245, 2);
            WriteAttributeValue("", 219, "/Carriers/formCarriers/", 219, 23, true);
#nullable restore
#line 9 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml"
WriteAttributeValue("", 242, id, 242, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""material-icons icon-red"">arrow_back</div>
            </a>
            <div class=""text-uppercase poppins medium size-24 pl-2"">CONTACTOS</div>
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
                        <th>Tipo de contacto</th>
                        <th>Nombre</th>
                        <th>Teléfono</th>
                        <th>Correo</th>
                        <th>Estatus</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
   ");
            WriteLiteral(@"             <tbody id=""table-info""></tbody>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90998dd9a72901d56b2ab56c8054c25c197ad6467939", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2340, "\"", 2348, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tipo de contacto</label>
                                <input type=""text"" class=""form-control"" name=""TipoContacto"" id=""TipoContacto"" required />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2707, "\"", 2715, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""Nombre"" id=""Nombre"" required />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3052, "\"", 3060, 0);
                EndWriteAttribute();
                WriteLiteral(@">Teléfono</label>
                                <input type=""text"" class=""form-control"" name=""Telefono"" id=""Telefono"" required />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 3470, "\"", 3478, 0);
                EndWriteAttribute();
                WriteLiteral(@">Correo</label>
                                <input type=""text"" class=""form-control"" name=""Correo"" id=""Correo"" required />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 3757, "\"", 3765, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control form-control-sm\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90998dd9a72901d56b2ab56c8054c25c197ad64610834", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90998dd9a72901d56b2ab56c8054c25c197ad64612090", async() => {
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
                    <br />
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
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--Modal global-->\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var dataContacts = [];

        $(window).ready(function () {
            loadTable();

            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                jsonData[""Id_Transportista""] = ");
#nullable restore
#line 116 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml"
                                          Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                console.log(jsonData);
                if (parseInt($(""#idEditar"").val()) != 0) {
                    $.post(""/Carriers/Contacts/putContacts"", jsonData, function (res) {
                        console.log(res);
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""/Carriers/Contacts/setContacts"", jsonData, function (res) {
                        loadTable();
                        dToast(""success"", ""Se guardo el registro"", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                        $('#frmRegister').trigger(""reset"");
");
                WriteLiteral(@"                    }).fail(function (error) {
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

                    let indice = dataContacts.findIndex(service => service.id === idEditar);
                    $(""#Nombre"").val(dataContacts[indice].nombre);
                    $(""#TipoContacto"").val(dataContacts[indice].tipoContacto);
                    $(""#Nombre"").val(dataContacts[indice].nombre);
                    $(""#Telefono"").val(dataContacts[indice].telefono);
   ");
                WriteLiteral(@"                 $(""#Correo"").val(dataContacts[indice].correo);
                    $('#Estatus option[value=""' + dataContacts[indice].estatus + '""]').attr(""selected"", true);
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
            $.get(""/Carriers/Contacts/getContacts/"", { ""Id_Transportista"":");
#nullable restore
#line 174 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Carriers\Contacts\Index.cshtml"
                                                                     Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"}, function (res) {
                dataContacts = res;
                console.log(res);
                $.each(dataContacts, function (item, key) {
                    $(""#table-info"").append(`
                             <tr>
                                <td>${nCon(key.tipoContacto)}</td>
                                <td>${nCon(key.nombre)}</td>
                                <td>${nCon(key.telefono)}</td>
                                <td>${nCon(key.correo)}</td>
                                <td>`+ statusTable(key.estatus) + `</td>
                                <td>
                                    <a href=""#"">
                                        <span class=""material-icons"" onclick=""showModal('EDITAR','Editar',${nCon(key.id)});"">
                                            mode_edit
                                        </span>
                                    </a>
                                </td>
                            </tr>`);
                });");
                WriteLiteral("\n                dTable(\"table-viajes\");\r\n            });\r\n        }\r\n    </script>\r\n");
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
