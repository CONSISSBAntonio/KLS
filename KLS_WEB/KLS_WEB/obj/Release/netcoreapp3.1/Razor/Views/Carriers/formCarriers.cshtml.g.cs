#pragma checksum "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0288c7af9572fd8115c5bd940afed2c0f191cd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_formCarriers), @"mvc.1.0.view", @"/Views/Carriers/formCarriers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0288c7af9572fd8115c5bd940afed2c0f191cd3", @"/Views/Carriers/formCarriers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d093829c613a0b3ec7efe9551a2b52f04eb20fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_formCarriers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
  
    ViewData["Title"] = "Configuracion transportista";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
   int id = ViewBag.id; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/rateYo/2.3.2/jquery.rateyo.min.css\">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""data-content p-4 text-left"">
    <div class=""p-4"">
        <div class=""text-left d-flex mb-3"">
            <a href=""/Carriers"">
                <div class=""material-icons icon-red"">arrow_back</div>
            </a>
            <div class=""text-uppercase poppins medium size-24 pl-2"">Transportista</div>
        </div>
        <div class=""row"">
            <div class=""col-md-4 text-right"">
                
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0288c7af9572fd8115c5bd940afed2c0f191cd36130", async() => {
                WriteLiteral(@"
                    
                    <button class=""btn btn-sm"" type=""submit"" style=""background-color:transparent;"">
                        <span class=""material-icons"" style=""color:cornflowerblue;"">
                            save
                        </span>
                    </button>

                    <div class=""p-4 shadow bg-white"">
                        <div class=""form-group row"">
                            <label class=""col-sm-5 col-form-label col-form-label-sm"">Id</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""idTransportista"" disabled=""disabled"" required>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Nombre Comercial</label>
                            <div class=""col-sm-7"">
                                <i");
                WriteLiteral(@"nput type=""text"" class=""form-control form-control-sm"" id=""NombreComercial"" name=""NombreComercial"" required>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Tamaño</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Tamanio"" name=""Tamanio"" required>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Servicio</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Servicio"" name=""Servicio"" required>
                            </div>
                        </div>
                        <div class=""form-grou");
                WriteLiteral(@"p row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Grado Confiabilidad (P)</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""GradoConfiabilidad"" name=""GradoConfiabilidad"" required>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Nivel Servicio Interno</label>
                            <div class=""col-sm-7"">
                                <div id=""rateYo""></div>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Comentario</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-co");
                WriteLiteral(@"ntrol-sm"" id=""Comentario"" name=""Comentario"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Fecha último viaje</label>
                            <div class=""col-sm-7"">
                                <input type=""date"" class=""form-control form-control-sm"" id=""FechaUltimoViaje"" name=""FechaUltimoViaje"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Estatus</label>
                            <div class=""col-sm-7"">
                                <select class=""form-control form-control-sm"" id=""Estatus"" name=""Estatus"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0288c7af9572fd8115c5bd940afed2c0f191cd310577", async() => {
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0288c7af9572fd8115c5bd940afed2c0f191cd311837", async() => {
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
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Razón Social</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""RazonSocial"" name=""RazonSocial"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">RFC</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Rfc"" name=""Rfc"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-la");
                WriteLiteral(@"bel-sm"">Dirección Fiscal</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""DireccionFiscal"" name=""DireccionFiscal"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Dirección Oficinas</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""DireccionOficinas"" name=""DireccionOficinas"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Dirección Patio</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Direccion");
                WriteLiteral(@"Patio"" name=""DireccionPatio"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Google Maps</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""GoogleMaps"" name=""GoogleMaps"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Página Web</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""PaginaWeb"" name=""PaginaWeb"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-");
                WriteLiteral(@"label-sm"">Facebook</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Facebook"" name=""Facebook"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Otra res social</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""OtraRed"" name=""OtraRed"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Banco</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Banco"" name=""Banco"">
                            </div>
    ");
                WriteLiteral(@"                    </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Cuenta</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""Cuenta"" name=""Cuenta"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Usuario Master</label>
                            <div class=""col-sm-7"">
                                <input type=""text"" class=""form-control form-control-sm"" id=""UsuarioMaster"" name=""UsuarioMaster"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-5 col-form-label col-form-label-sm"">Contraseña</label>
                            <div class=""co");
                WriteLiteral("l-sm-7\">\r\n                                <input type=\"password\" class=\"form-control form-control-sm\" id=\"Contrasena\" name=\"Contrasena\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
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
            WriteLiteral(@"
            </div>

            <div class=""col-md-8"">
                <div class=""catalog-list"">

                    <a href=""/Carriers/Operators"" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                people
                            </span>
                            <div class=""name font-barlow"">Operadores</div>
                        </div>
                    </a>

                    <a href=""/Carriers/Inventory"" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                local_shipping
                            </span>
                            <div class=""name font-barlow"">Inventario</div>
                        </div>
                    </a>

                    <a");
            BeginWriteAttribute("href", " href=\"", 11070, "\"", 11098, 2);
            WriteAttributeValue("", 11077, "/Carriers/Library/", 11077, 18, true);
#nullable restore
#line 192 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
WriteAttributeValue("", 11095, id, 11095, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                store
                            </span>
                            <div class=""name font-barlow"">Biblioteca digital</div>
                        </div>
                    </a>

                    <a");
            BeginWriteAttribute("href", " href=\"", 11466, "\"", 11495, 2);
            WriteAttributeValue("", 11473, "/Carriers/Contacts/", 11473, 19, true);
#nullable restore
#line 201 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
WriteAttributeValue("", 11492, id, 11492, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                call
                            </span>
                            <div class=""name font-barlow"">Contactos</div>
                        </div>
                    </a>

                    <a");
            BeginWriteAttribute("href", " href=\"", 11853, "\"", 11888, 2);
            WriteAttributeValue("", 11860, "/Carriers/Certifications/", 11860, 25, true);
#nullable restore
#line 210 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
WriteAttributeValue("", 11885, id, 11885, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                workspace_premium
                            </span>
                            <div class=""name font-barlow"">Certificaciones</div>
                        </div>
                    </a>

                    <a");
            BeginWriteAttribute("href", " href=\"", 12265, "\"", 12289, 2);
            WriteAttributeValue("", 12272, "/Carriers/Box/", 12272, 14, true);
#nullable restore
#line 219 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
WriteAttributeValue("", 12286, id, 12286, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                all_inbox
                            </span>
                            <div class=""name font-barlow"">Tipos de Mercancia</div>
                        </div>
                    </a>

                    <a");
            BeginWriteAttribute("href", " href=\"", 12661, "\"", 12688, 2);
            WriteAttributeValue("", 12668, "/Carriers/Routes/", 12668, 17, true);
#nullable restore
#line 228 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
WriteAttributeValue("", 12685, id, 12685, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""catalog"">
                        <div class=""content"">
                            <span class=""material-icons"">
                                commute
                            </span>
                            <div class=""name font-barlow"">Rutas</div>
                        </div>
                    </a>

                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/rateYo/2.3.2/jquery.rateyo.min.js""></script>
    <script>
        $(window).ready(function () {
            valId();
            $(""#frmRegister"").submit(function (event) {
                event.preventDefault();
                var jsonData = convertJson($(""#frmRegister""));
                var normalFill = $(""#rateYo"").rateYo(""option"", ""rating"");
                jsonData[""NivelServicio""] = normalFill;
                jsonData[""id""] = ");
#nullable restore
#line 253 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
                            Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                console.log(jsonData);\r\n\r\n                if (parseInt(");
#nullable restore
#line 256 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
                        Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") == 0) {
                    $.post(""/Carriers/setCarriers"", jsonData, function (res) {
                        console.log(res);
                        $(location).attr('href', '/Carriers/formCarriers/' + res.id);
                        dToast(""success"", ""Registro guardado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de guardar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
                } else {
                    $.post(""/Carriers/putCarriers"",jsonData, function (res) {
                        console.log(res);
                        dToast(""success"", ""Registro actualizado exitosamente."", ""Registrado"");
                    }).fail(function (error) {
                        dToast(""error"", ""Error al tratar de actualizar el registro"", ""Error"");
                        $("".guardar"").attr(""disabled"", false);
                    });
   ");
                WriteLiteral("             }\r\n            });\r\n        });\r\n\r\n        function valId(){\r\n            if (parseInt(");
#nullable restore
#line 278 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
                    Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(") != 0) {\r\n                $(\"#idTransportista\").val(");
#nullable restore
#line 279 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
                                     Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n                $.get(\"/Carriers/getCarrier/\", { \"id\":");
#nullable restore
#line 280 "C:\Users\Consiss\source\repos\KLS\KLS_WEB\KLS_WEB\Views\Carriers\formCarriers.cshtml"
                                                 Write(id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"}, function (res) {

                    $(""#rateYo"").rateYo({
                        normalFill: ""#A0A0A0"",
                        rating: res.nivelServicio,
                        fullStar: true
                    });

                    console.log(res);
                    $(""#Banco"").val(res.banco);
                    $(""#Comentario"").val(res.comentario);
                    $(""#Contrasena"").val(res.contrasena);
                    $(""#Cuenta"").val(res.cuenta);
                    $(""#DireccionFiscal"").val(res.direccionFiscal);
                    $(""#DireccionOficinas"").val(res.direccionOficinas);
                    $(""#DireccionPatio"").val(res.direccionPatio);
                    $(""#Estatus"").val(res.estatus);
                    $(""#Facebook"").val(res.facebook);
                    $(""#FechaUltimoViaje"").val(res.fechaUltimoViaje);
                    $(""#GoogleMaps"").val(res.googleMaps);
                    $(""#GradoConfiabilidad"").val(res.gradoConfiabilidad);
            ");
                WriteLiteral(@"        $(""#NivelServicio"").val(res.nivelServicio);
                    $(""#NombreComercial"").val(res.nombreComercial);
                    $(""#OtraRed"").val(res.otraRed);
                    $(""#PaginaWeb"").val(res.paginaWeb);
                    $(""#RazonSocial"").val(res.razonSocial);
                    $(""#Rfc"").val(res.rfc);
                    $(""#Servicio"").val(res.servicio);
                    $(""#Tamanio"").val(res.tamanio);
                    $(""#UsuarioMaster"").val(res.usuarioMaster);
                }).fail(function (error, xhr, status) {
                    console.log(error);
                });

            } else {
                $(""#rateYo"").rateYo({
                    normalFill: ""#A0A0A0"",
                    rating: 0,
                    fullStar: true
                });
                $(""#idTransportista"").val(""0000"");
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