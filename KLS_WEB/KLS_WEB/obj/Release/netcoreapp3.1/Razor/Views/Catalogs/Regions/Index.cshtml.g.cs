#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\Regions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82463981b01c147ebfd6a2e04009289cbfe6e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Regions_Index), @"mvc.1.0.view", @"/Views/Catalogs/Regions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82463981b01c147ebfd6a2e04009289cbfe6e7b", @"/Views/Catalogs/Regions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Regions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\Regions\Index.cshtml"
  
    ViewData["Title"] = "Regions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""p-4"">
    <div class=""d-flex flex-nowrap"">
        <div class=""p-2"">
            <div class=""text-left d-flex p-2"">
                <a href=""/Catalogs/Geografia"">
                    <div class=""material-icons icon-red"">arrow_back</div>
                </a>
                <div class=""text-uppercase poppins medium size-24 pl-2"">REGIONES</div>
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
                    <th>Estados</th>
                    <th>Estatus</th>
                    <th>A");
            WriteLiteral(@"cciones</th>  
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
            </div>
            <div class=""modal-body text-left"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82463981b01c147ebfd6a2e04009289cbfe6e7b6945", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 1997, "\"", 2005, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"" id=""nombre"" required />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 2284, "\"", 2292, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control form-control-sm\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82463981b01c147ebfd6a2e04009289cbfe6e7b8236", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82463981b01c147ebfd6a2e04009289cbfe6e7b9491", async() => {
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
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2828, "\"", 2836, 0);
                EndWriteAttribute();
                WriteLiteral(@">Estado</label>
                                <br />
                                <select class=""form-control"" id=""id_estado"" name=""id_estado"" style=""width:100%;"">
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div id=""estadosBtn""></div>
                        </div>
                    </div>
                    <div class=""pt-3"">
                        <button type=""submit"" class=""btn btn-dark guardar"" style=""width:25%;"" id=""btnAccion"">
                            Guardar
                        </button>
                    </div>
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
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn\" data-dismiss=\"modal\" >Cerrar</button>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--Modal global-->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        var btnGroup = [];
        var dataRegions = [];
        var catEstado = [];

        $(document).ready(function () {
            loadState();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                jsonData[""Region_Has_Estados""]= btnGroup;

                if (parseInt($(""#idEditar"").val()) != 0) {
                    $.post(""Regions/putRegion"", jsonData, function (res) {
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""Regions/");
                WriteLiteral(@"setRegion"", jsonData, function (res) {
                        loadTable();
                        dToast(""success"", ""Se guardó el registro"", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                        btnGroup.length = 0;
                        $(""#estadosBtn"").empty();
                        $('#frmRegister').trigger(""reset"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                }
            });
        });

        $('#id_estado').change(function () {
            let valor = $(this).val();
            let texto = $(this).find(""option:selected"").text();
            if (valor != 0) {
                btnGroup.push({ ""id_estado"": valor });
                loadBtn();
            }
        });

        function loadBtn() {
            $(""#estadosBtn"").empty");
                WriteLiteral(@"();
            try {
                $.each(btnGroup, function (item, key) {
                    var indice_e = catEstado.findIndex(service => parseInt(service.id) === parseInt(key.id_estado));
                    $(""#estadosBtn"").append(
                        `
                            <div style=""padding-bottom: 1vh;display: inline-block;"">
                                <button type=""button"" class=""btn btn-dark btn-sm"" id=""${key.id_estado}"">
                                    ${catEstado[indice_e].nombre}        
                                    <i class=""material-icons"" onclick=""delBtn(${key.id_estado})"">
                                        delete_outline
                                    </i>
                                </button>
                            </div>
                            
                        `
                    );
                });
            } catch (error) {
                dToast(""error"", ""Error: "" + error, ""Atencion!"");
          ");
                WriteLiteral(@"  }

            selEstado();

        }

        function delBtn(id) {
            let indice = btnGroup.findIndex(estado => parseInt(estado.id_estado) === parseInt(id));
            if (indice < 0) {
                dToast(""error"", ""No se encontro estado a eliminar!"", ""Atencion!"");
            } else {
                btnGroup.splice(indice,1);
                $(""#"" + id).remove();
                $(""#"" + id).hide(""slow"");
                selEstado();
            }
        }


        function showModal(titulo = ""Title"", accion, idEditar = 0) {
            $('#frmRegister').trigger(""reset"");
            $("".guardar"").html(accion);
            $(""#titulo-modal"").empty("""");
            $(""#titulo-modal"").html(titulo);
            $(""#idEditar"").val(idEditar);
            btnGroup.length = 0;
            if (accion == ""Editar"") {
                try {
                    let indice = dataRegions.findIndex(service => service.id === idEditar);
                    $.each(dataRegions[i");
                WriteLiteral(@"ndice].region_Has_Estados, function (item, key) {
                        btnGroup.push({ ""id_estado"": key.id_estado});
                    });
                    loadBtn();
                    $(""#nombre"").val(dataRegions[indice].nombre);                    
                    $('#estatus option[value=""' + dataRegions[indice].estatus + '""]').attr(""selected"", true);
                    $(""#modalDiv"").modal(""show"");
                } catch (error) {
                    dToast(""error"", ""Error al tratar de editar, intenta recargar la página."", ""Error"");
                    $(""#modalDiv"").modal(""hide"");
                }
            } else {
                $(""#modalDiv"").modal(""show"");
                loadBtn();
            }
        }

        //Cargar estados
        function loadState() {
            $.get(""State/getState"", function (res) {
                catEstado = res;
                selEstado();
                //$(""#id_estado"").select2();
                dSelect('id_estado');
");
                WriteLiteral(@"                loadTable();
            }).fail(function (error) {
                dToast(""error"", ""Error al obtener paises"", ""Atencion!"");
            });
        }
        function selEstado(){
            $(""#id_estado"").empty();
            $(""#id_estado"").append(`<option value=""0"">selecciona</option>`);
            try {
                $.each(catEstado, function (item, key) {
                    if (key.estatus != 2) {
                        let indice = btnGroup.findIndex(estado => parseInt(estado.id_estado) === parseInt(key.id));
                        if (indice < 0) {
                            $(""#id_estado"").append(`<option value=""${key.id}"">${key.nombre}</option>`);
                        }
                    }

                });
            } catch (error) {
                dToast(""error"", ""Error al listar estados: "" + error, ""Error"");
            }
        }
        function loadTable() {
            var stable = $('.table-viajes').DataTable();
            stable");
                WriteLiteral(@".destroy();
            $(""#table-info"").empty();
            $.get(""Regions/getRegion"", function (res) {
                dataRegions = res;
                $.each(res, function (item, key) {
                    let estado = """";
                    $.each(key.region_Has_Estados, function (item_r, key_r) {
                        let indice_e = catEstado.findIndex(service => service.id === key_r.id_estado);
                        estado += catEstado[indice_e].nombre+"","";
                    });

                    $(""#table-info"").append(`
                             <tr>
                                <td>${nCon(key.nombre)}</td>
                                <td>${estado}</td>
                                <td>`+ statusTable(key.estatus) + `</td>
                                <td>
                                    <a href=""#"">
                                        <span class=""material-icons"" onclick=""showModal('EDITAR','Editar',${nCon(key.id)});"">
                           ");
                WriteLiteral(@"                 mode_edit
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
