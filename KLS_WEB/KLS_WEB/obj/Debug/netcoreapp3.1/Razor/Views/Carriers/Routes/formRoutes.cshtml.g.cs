#pragma checksum "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\Routes\formRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d757b0ba843bb3f3b163f6e7a22f939c1840b7d7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d757b0ba843bb3f3b163f6e7a22f939c1840b7d7", @"/Views/Carriers/Routes/formRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Routes_formRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(">\r\n                <div class=\"material-icons icon-red\">arrow_back</div>\r\n            </a>\r\n            <div class=\"text-uppercase poppins medium size-24 pl-2\">Transportista</div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d76132", async() => {
                WriteLiteral(@"
            <button class=""btn btn-sm"" type=""submit"" style=""background-color:transparent;"">
                <span class=""material-icons"" style=""color:cornflowerblue;"">
                    save
                </span>
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
                                <select class=""f");
                WriteLiteral("orm-control form-control-sm\" id=\"Id_Estado_Origen\" name=\"Id_Estado_Origen\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d77603", async() => {
                    WriteLiteral("Seleccionar");
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
                            <label class=""col-4 col-form-label col-form-label-sm"">Ciudad Origen</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Ciudad_Origen"" name=""Id_Ciudad_Origen"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d79325", async() => {
                    WriteLiteral("Seleccionar");
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
                            <label class=""col-4 col-form-label col-form-label-sm"">Estado Destino</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Estado_Destino"" name=""Id_Estado_Destino"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d711050", async() => {
                    WriteLiteral("Seleccionar");
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
                            <label class=""col-4 col-form-label col-form-label-sm"">Ciudad Destino</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control form-control-sm"" id=""Id_Ciudad_Destino"" name=""Id_Ciudad_Destino"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d712776", async() => {
                    WriteLiteral("Seleccionar");
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
                            <label class=""col-4 col-form-label col-form-label-sm"">Total de kilometros</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""TotalKilometros"" name=""TotalKilometros"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">% Eficiencia</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Eficiencia"" name=""Eficiencia"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label c");
                WriteLiteral(@"lass=""col-4 col-form-label col-form-label-sm"">Total de horas</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""TotalHoras"" name=""TotalHoras"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-4 col-form-label col-form-label-sm"">Seguridad</label>
                            <div class=""col-sm-8"">
                                <select id=""Seguridad"" name=""Seguridad"" class=""form-control form-control-sm"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d715784", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d717482", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d719627", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757b0ba843bb3f3b163f6e7a22f939c1840b7d721325", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        $(window).ready(function () {

            loadTable();

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
                WriteLiteral(";\r\n\r\n                if (parseInt(");
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
            $(""#i");
                WriteLiteral("dEditar\").attr(\"disabled\", true);\r\n            if (");
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
                        $(""#RestriccionCircuito"").val(res.restriccionCircuito);
                        $(""#Segur");
                WriteLiteral(@"idad"").val(res.seguridad);
                        $(""#TipoDeViaje"").val(res.tipoDeViaje);
                        $(""#TotalHoras"").val(res.totalHoras);
                        $(""#Total_Kilometros"").val(res.total_Kilometros);
                    }
                    console.log(dataRoutes);
                });
            } 
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
