#pragma checksum "C:\Users\Consiss\Documents\DOCS\KLS\DESARROLLO\KLS_WEB\KLS_WEB\Views\Catalogs\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7931b4290d897e0644024bc77f90406438f335ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Country_Index), @"mvc.1.0.view", @"/Views/Catalogs/Country/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7931b4290d897e0644024bc77f90406438f335ee", @"/Views/Catalogs/Country/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Consiss\Documents\Visual Studio 2019\GitHubProjects\KLS\KLS_WEB\KLS_WEB\Views\Catalogs\Country\Index.cshtml"
  
    ViewData["Title"] = "Paises";

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
                <div class=""text-uppercase poppins medium size-24 pl-2"">PAISES</div>
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
                    <th>País</th>
                    <th>Estatus</th>
                    <th>Acciones</th>
                </tr>
     ");
            WriteLiteral(@"       </thead>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7931b4290d897e0644024bc77f90406438f335ee7092", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEditar"" value=""0"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("class", " class=\"", 2132, "\"", 2140, 0);
                EndWriteAttribute();
                WriteLiteral(@">País</label>
                                <input type=""text"" class=""form-control"" name=""pais"" id=""pais"" required />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 2413, "\"", 2421, 0);
                EndWriteAttribute();
                WriteLiteral(">Estatus</label>\r\n                            <select class=\"form-control form-control-sm\" name=\"estatus\" id=\"estatus\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7931b4290d897e0644024bc77f90406438f335ee8375", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7931b4290d897e0644024bc77f90406438f335ee9630", async() => {
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

        var dataCountry = [];

        $(document).ready(function () {
            loadTable();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));

                if (parseInt($(""#idEditar"").val()) != 0) {
                    $.post(""Country/putCountry"", jsonData, function (res) {
                        console.log(res);
                        loadTable();
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""Country/setCountry"", jsonData, function (res) {
                        loadTab");
                WriteLiteral(@"le();
                        dToast(""success"", ""Se guardó el registro"", ""Registrado"");
                        $("".guardar"").attr(""disabled"", false);
                        $('#frmRegister').trigger(""reset"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                }

                //$.post(""Country/setCountry"", jsonData, function (res) {
                //    loadTable();
                //    dToast(""success"", ""Se guardo el registro"", ""Registrado"");
                //    $("".guardar"").attr(""disabled"", false);
                //    $('#frmRegister').trigger(""reset"");
                //}).fail(function (error) {
                //    dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                //    $("".guardar"").attr(""disabled"", false);
                //});

            });
    ");
                WriteLiteral(@"    });

        function showModal(titulo = ""Title"", accion, idEditar = 0) {
            $('#frmRegister').trigger(""reset"");
            $("".guardar"").html(accion);
            $(""#titulo-modal"").empty("""");
            $(""#titulo-modal"").html(titulo);
            $(""#idEditar"").val(idEditar);
            if (accion == ""Editar"") {
                try {
                    let indice = dataCountry.findIndex(service => service.id === idEditar);
                    $(""#pais"").val(dataCountry[indice].pais);
                    $('#estatus option[value=""' + dataCountry[indice].estatus + '""]').attr(""selected"", true);
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
");
                WriteLiteral(@"            var stable = $('.table-viajes').DataTable();
            stable.destroy();
            $(""#table-info"").empty();
            $.get(""Country/getCountry"", function (res) {
                dataCountry = res;
                $.each(res, function (item, key) {
                    $(""#table-info"").append(`
                             <tr>
                                <td>${nCon(key.pais)}</td>
                                <td>`+ statusTable(key.estatus) + `</td>
                                <td>
                                    <a href=""#"">
                                        <span class=""material-icons"" onclick=""showModal('EDITAR','Editar',${nCon(key.id)});"">
                                            mode_edit
                                        </span>
                                    </a>
                                </td>
                            </tr>`);
                });
                dTable(""table-viajes"");
            }).fail(function (erro");
                WriteLiteral("r) {\r\n                dToast(\"error\", \"Error al tratar de obtener los registros, intenta cerrar sesión y volver a iniciar.\", \"Error\");\r\n            });\r\n        }\r\n    </script>\r\n");
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
