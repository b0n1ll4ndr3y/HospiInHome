#pragma checksum "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5485d4387fb6502d76be18d93690d80b862d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiInHome.App.FrontEnd.Pages.Pacientes.Pages_Pacientes_DetallesP), @"mvc.1.0.razor-page", @"/Pages/Pacientes/DetallesP.cshtml")]
namespace HospiInHome.App.FrontEnd.Pages.Pacientes
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
#line 1 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospiInHome.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5485d4387fb6502d76be18d93690d80b862d6a", @"/Pages/Pacientes/DetallesP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed31c786a6c0c7758b090f0a8c5b2905a706bf77", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_DetallesP : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditPaciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Signos/ListSV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListPacientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
  
    int idPaciente = Model.Paciente.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles del Paciente No. ");
#nullable restore
#line 7 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                         Write(Model.Paciente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br>\r\n<div class=\"container\">\r\n    <table class=\"table table-hover\">\r\n        <tbody>\r\n            <tr>\r\n                <th scope=\"row\">Nombres:</th>\r\n                <td>");
#nullable restore
#line 14 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Apellidos:</th>\r\n                <td>");
#nullable restore
#line 18 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Tipo de Documento:</th>\r\n                <td>");
#nullable restore
#line 22 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.TipoDocumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">No. Documento:</th>\r\n                <td>");
#nullable restore
#line 26 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Género:</th>\r\n                <td>");
#nullable restore
#line 30 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Fecha de Nacimiento:</th>\r\n                <td>");
#nullable restore
#line 34 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.FechaNacimiento.ToString("yyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Geolocalización:</th>\r\n                <td>[ ");
#nullable restore
#line 38 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                 Write(Model.Paciente.Latitud);

#line default
#line hidden
#nullable disable
            WriteLiteral(" N, ");
#nullable restore
#line 38 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                                            Write(Model.Paciente.Longitud);

#line default
#line hidden
#nullable disable
            WriteLiteral(" E ]</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Teléfono:</th>\r\n                <td>");
#nullable restore
#line 42 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Plan Medico:</th>\r\n                <td>");
#nullable restore
#line 46 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.PlanMedico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Familiar designado:</th>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1757, 2);
            WriteAttributeValue("", 1681, "/Pacientes/Familiares/Detail?idfamiliardesignado=", 1681, 49, true);
#nullable restore
#line 50 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
WriteAttributeValue("", 1730, Model.FamiliarDesignado.Id, 1730, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                                                                                                      Write(Model.FamiliarDesignado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                                                                                                                                      Write(Model.FamiliarDesignado.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Medico tratante:</th>\r\n                <td>");
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Enfermera tratante:</th>\r\n                <td>");
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Histórial clínico:</th>\r\n                <td>");
#nullable restore
#line 62 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
               Write(Model.Paciente.HistoriaClinica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5485d4387fb6502d76be18d93690d80b862d6a11683", async() => {
                WriteLiteral("Editar Paciente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idPaciente", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                                                                       WriteLiteral(idPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPaciente"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idPaciente", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPaciente"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5485d4387fb6502d76be18d93690d80b862d6a14013", async() => {
                WriteLiteral("Signos Vitales");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idPaciente", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\ProysCicloIII\HospiInHome\HospiInHome.App\HospiInHome.App.FrontEnd\Pages\Pacientes\DetallesP.cshtml"
                                                                        WriteLiteral(idPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPaciente"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idPaciente", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPaciente"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5485d4387fb6502d76be18d93690d80b862d6a16343", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiInHome.App.FrontEnd.Pages.DetallesPModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiInHome.App.FrontEnd.Pages.DetallesPModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiInHome.App.FrontEnd.Pages.DetallesPModel>)PageContext?.ViewData;
        public HospiInHome.App.FrontEnd.Pages.DetallesPModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
