#pragma checksum "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Agendamiento\Agenda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fede906b3862b1660e311f6ef1df80846fbac904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Agendamiento.Pages_Agendamiento_Agenda), @"mvc.1.0.razor-page", @"/Pages/Agendamiento/Agenda.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Agendamiento
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
#line 1 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fede906b3862b1660e311f6ef1df80846fbac904", @"/Pages/Agendamiento/Agenda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Agendamiento_Agenda : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""ftco-section"" style=""padding: 0 !important"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""content w-100"">
                    <div class=""calendar-container"">
                        <div class=""calendar"">
                            <div class=""year-header"">
                                <span class=""left-button fa fa-chevron-left"" id=""prev""> </span>
                                <span class=""year"" id=""label""></span>
                                <span class=""right-button fa fa-chevron-right"" id=""next""> </span>
                            </div>
                            <table class=""months-table w-100"">
                                <tbody>
                                    <tr class=""months-row"">
                                        <td class=""month"">Jan</td>
                                        <td class=""month"">Feb</td>
                                        <td class=""month"">Mar<");
            WriteLiteral(@"/td>
                                        <td class=""month"">Apr</td>
                                        <td class=""month"">May</td>
                                        <td class=""month"">Jun</td>
                                        <td class=""month"">Jul</td>
                                        <td class=""month"">Aug</td>
                                        <td class=""month"">Sep</td>
                                        <td class=""month"">Oct</td>
                                        <td class=""month"">Nov</td>
                                        <td class=""month"">Dec</td>
                                    </tr>
                                </tbody>
                            </table>

                            <table class=""days-table w-100"">
                                <td class=""day"">Sun</td>
                                <td class=""day"">Mon</td>
                                <td class=""day"">Tue</td>
                                <td class=""da");
            WriteLiteral(@"y"">Wed</td>
                                <td class=""day"">Thu</td>
                                <td class=""day"">Fri</td>
                                <td class=""day"">Sat</td>
                            </table>
                            <div class=""frame"">
                                <table class=""dates-table w-100"">
                                    <tbody class=""tbody"">
                                    </tbody>
                                </table>
                            </div>
                            <button class=""button"" id=""add-button"" style=""position: absolute; top: 20px; height: 40px;"">
                                Solicitar cita
                            </button>
                        </div>
                    </div>
                    <div class=""events-container"">
                    </div>
                    <div class=""dialog"" id=""dialog"">
                        <h2 class=""dialog-header""> Solicitar cita </h2>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fede906b3862b1660e311f6ef1df80846fbac9047191", async() => {
                WriteLiteral(@"
                            <div class=""form-container"" align=""center"">
                                <label class=""form-label"" id=""valueFromMyButton"" for=""name"">Observación</label>
                                <input class=""input"" type=""text"" id=""name"" maxlength=""36"">
                                <label class=""form-label"" id=""valueFromMyButton"" for=""count"">
                                    Hora militar de la cita (de 8 a 20)
                                </label>
                                <input class=""input"" type=""number"" id=""count"" min=""0"" max=""1000000"" maxlength=""2"">
                                <input type=""button"" value=""Crear solicitud"" class=""button button-white"" id=""ok-button"">
                                <input type=""button"" value=""Cancel"" class=""button""
                                    style=""margin: 20px; background: #666;"" id=""cancel-button"">
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.AgendaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.AgendaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.AgendaModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.AgendaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
