#pragma checksum "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662ff8a995523843323d569e9c79b856b647a742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_Routes_formRoutes), @"mvc.1.0.view", @"/Views/Carriers/Routes/formRoutes.cshtml")]
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
#line 1 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\_ViewImports.cshtml"
using KLS_WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662ff8a995523843323d569e9c79b856b647a742", @"/Views/Carriers/Routes/formRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Routes_formRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
  
    ViewData["Title"] = "Transportista|Rutas Form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
   int idRuta = ViewBag.idRuta; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"data-content p-4 text-left\">\r\n    <div class=\"p-4\">\r\n        <div class=\"text-left d-flex mb-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 248, "\"", 275, 2);
            WriteAttributeValue("", 255, "/Carriers/Routes/", 255, 17, true);
#nullable restore
#line 10 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
WriteAttributeValue("", 272, id, 272, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"material-icons icon-red\">arrow_back</div>\r\n            </a>\r\n            <div class=\"text-uppercase poppins medium size-24 pl-2\">Ruta Transportista</div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a7426719", async() => {
                WriteLiteral(@"
            
            <button class=""btn btn-sm"" type=""submit"" style=""background-color:transparent;"">
                <span class=""material-icons"" style=""color:cornflowerblue;"" id=""span-icon""></span>
            </button>

            <div class=""row"">
                <div class=""col-md-4 text-right"">
                    <div class=""p-4 shadow bg-white"">
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">ID</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""idEditar"" name=""Id"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Estado Origen</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control f");
                WriteLiteral(@"orm-control-sm"" id=""Id_Estado_Origen"" name=""Id_Estado_Origen"" style=""width:100%;""></select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Ciudad Origen</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Ciudad_Origen"" name=""Id_Ciudad_Origen"" style=""width:100%;"">
   
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Estado Destino</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Estado_Destino"" name=""Id_Estado_Destino"" style=""width:100%;""></select>
                       ");
                WriteLiteral(@"     </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Ciudad Destino</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Ciudad_Destino"" name=""Id_Ciudad_Destino"" style=""width:100%;""></select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Total de kilometros</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""TotalKilometros"" name=""TotalKilometros"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-for");
                WriteLiteral(@"m-label-sm"">% Eficiencia</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Eficiencia"" name=""Eficiencia"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Total de horas</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""TotalHoras"" name=""TotalHoras"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Seguridad</label>
                            <div class=""col-sm-8"">
                                <select id=""Seguridad"" name=""Seguridad"" class=""form-control form-control-sm"">
                        ");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a74211367", async() => {
                    WriteLiteral("Selecciona");
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
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Demanda</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Demanda"" name=""Demanda"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a74213065", async() => {
                    WriteLiteral("Selecciona");
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
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Restricción de Circ.</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""RestriccionCircuito"" name=""Contrasena"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Tipo de viaje</label>
                            <div class=""col-sm-8"">
                                <select id=""TipoDeViaje"" name=""TipoDeViaje"" class=""form-control form-control-sm"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a74215210", async() => {
                    WriteLiteral("Selecciona");
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
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Estatus</label>
                            <div class=""col-sm-8"">
                                <select id=""Estatus"" name=""Estatus"" class=""form-control form-control-sm"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a74216908", async() => {
                    WriteLiteral("Activo");
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662ff8a995523843323d569e9c79b856b647a74218168", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""p-4 shadow bg-white"">
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Frec. de validación</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" name=""FrecValidacion"" id=""FrecValidacion"" class=""form-control form-control-sm""/>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Restricción de Circ.</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" name=""RestriccionCirc"" id=""RestriccionCirc"" class=""form-control form-control-");
                WriteLiteral(@"sm""/>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Observaciones</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" name=""Observacion"" id=""Observacion"" class=""form-control form-control-sm""/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        dataRoutes = [];
        var dataCiudad = [];
        var dataEstado = [];

        $(window).ready(function () {
            getCiudad();
            getEstado();
            //loadTable();

            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                jsonData[""Id_Transportista""] = ");
#nullable restore
#line 156 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
                                          Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                console.log(jsonData);\r\n                if (parseInt(");
#nullable restore
#line 158 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
                        Write(idRuta);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") == 0) {
                    $.post(""/Carriers/Routes/setRoutes/"", jsonData, function (res) {
                        $('#frmRegister').trigger(""reset"");
                        dToast(""success"", ""Registro guardado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""/Carriers/Routes/putRoutes/"", jsonData, function (res) {
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de actualizar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                }

            });
        });

        function loadTable() {
            //$(""");
                WriteLiteral("#idEditar\").attr(\"disabled\", true);\r\n            if (");
#nullable restore
#line 180 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
           Write(idRuta);

#line default
#line hidden
#nullable disable
                WriteLiteral("!= 0) {\r\n                $.get(\"/Carriers/Routes/getRoutes/\", { \"Id\":");
#nullable restore
#line 181 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml"
                                                       Write(idRuta);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"}, function (res) {
                    dataRoutes = res;
                    if (res != null) {

                        $(""#span-icon"").append(""edit"");

                        $(""#idEditar"").val(res.id);
                        $(""#Demanda"").val(res.demanda);
                        $(""#Eficiencia"").val(res.eficiencia);
                        $(""#Estatus"").val(res.estatus);
                        $(""#FrecValidacion"").val(res.frecValidacion);
                        $(""#Id_Ciudad_Destino"").val(res.id_Ciudad_Destino);
                        $(""#Id_Ciudad_Origen"").val(res.id_Ciudad_Origen);
                        $(""#Id_Estado_Destino"").val(res.id_Estado_Destino);
                        $(""#Id_Estado_Origen"").val(res.id_Estado_Origen);
                        $(""#Id_Transportista"").val(res.id_Transportista);
                        $(""#Observacion"").val(res.observacion);
                        $(""#Restriccion"").val(res.restriccion);
                        $(""#RestriccionCircuito"").val");
                WriteLiteral(@"(res.restriccionCircuito);
                        $(""#Seguridad"").val(res.seguridad);
                        $(""#TipoDeViaje"").val(res.tipoDeViaje);
                        $(""#TotalHoras"").val(res.totalHoras);
                        $(""#Total_Kilometros"").val(res.total_Kilometros);
                    } else {
                        $(""#span-icon"").append(""save"");
                    }
                });
            }
        }

        function getEstado() {
            $.get(""/../../Catalogs/Geography/State/getState"", function (res) {
                dataEstado = res;
                $(""#Id_Estado_Origen"").empty();
                $(""#Id_Estado_Destino"").empty();
                $.each(res, function (item, key) {
                    $(""#Id_Estado_Origen"").append(`<option value=""${key.id}"">${key.nombre}</option>`);
                    $(""#Id_Estado_Destino"").append(`<option value=""${key.id}"">${key.nombre}</option>`);
                });
                $(""#Id_Estado_Origen"").select");
                WriteLiteral(@"2();
                $(""#Id_Estado_Destino"").select2();
            }).fail(function (error) {
                dToast(""error"", ""Error al obtener paises"", ""Atencion!"");
            });
        }

        function getCiudad() {
            $.get(""/../../Catalogs/Geography/City/getCity"", function (res) {
                dataCiudad = res;
                $(""#Id_Ciudad_Origen"").empty();
                $(""#Id_Ciudad_Destino"").empty();
                $.each(res, function (item, key) {
                    $(""#Id_Ciudad_Origen"").append(`<option value=""${key.id}"">${key.nombre}</option>`);
                    $(""#Id_Ciudad_Destino"").append(`<option value=""${key.id}"">${key.nombre}</option>`);
                });
                $(""#Id_Ciudad_Origen"").select2();
                $(""#Id_Ciudad_Destino"").select2();
                loadTable();
            }).fail(function (error) {
                dToast(""error"", ""Error al obtener paises"", ""Atencion!"");
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
