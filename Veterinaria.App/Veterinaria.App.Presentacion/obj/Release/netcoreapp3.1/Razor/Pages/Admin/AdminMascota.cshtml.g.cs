#pragma checksum "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c928c17833b63046ae0081811ddb52bde55ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Admin.Pages_Admin_AdminMascota), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminMascota.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c928c17833b63046ae0081811ddb52bde55ce0", @"/Pages/Admin/AdminMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_AdminMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/AdminCuidador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: absolute; right: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary bg-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Del", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
 if (@Model.cuidadorActual != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 style=\"margin: 25px 0px; color: gray; font-size: 21px;\">Mascotas de ");
#nullable restore
#line 7 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                                                       Write(Model.cuidadorActual.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accordion\" id=\"accordionVeterinarios\">\r\n\r\n    <div class=\"card\">\r\n        <div class=\"card-header\" id=\"headingTwo\">\r\n            <h2 class=\"mb-0\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                 if (@Model.cuidadorActual != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c928c17833b63046ae0081811ddb52bde55ce07763", async() => {
                WriteLiteral("\r\n                        Regresar\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-page-route-idCuidador", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
AddHtmlAttributeValue("", 608, Model.cuidadorActual.Id, 608, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseListaVeterinarios"" aria-expanded=""true""
                    aria-controls=""collapseListaVeterinarios"">
                    Lista de mascotas
                </button>
            </h2>
        </div>

        <div id=""collapseListaVeterinarios""");
            BeginWriteAttribute("class", " class=\"", 1154, "\"", 1223, 1);
#nullable restore
#line 33 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
WriteAttributeValue("", 1162, Model.modoPage == "adicion" ? "collapse show" : "collapse", 1162, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
            aria-labelledby=""headingOne"" data-parent=""#accordionVeterinarios"">
            <div class=""card-body"">

                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Nombre</th>
");
            WriteLiteral(@"                            <th scope=""col"">Raza</th>
                            <th>
                                Acciones
                            </th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 51 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                         if (@Model.cuidadorActual != null)
                        {

                            foreach (var v in Model.cuidadorActual.Mascotas)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 57 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                   Write(v.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 58 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                   Write(v.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                   Write(v.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral(@"                                    <td>

                                        <div class=""container"" style=""width: 260px;"">
                                            <div class=""row"">
                                                <div class=""col-4"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c928c17833b63046ae0081811ddb52bde55ce013515", async() => {
                WriteLiteral("\r\n                                                        Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idVeterinario", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                                             WriteLiteral(v.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idVeterinario"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idVeterinario", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idVeterinario"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""col-4"">
                                                    <!-- Button trigger modal -->
                                            <button type=""button"" class=""btn btn-primary bg-danger"" data-toggle=""modal""
                                                data-target=""#exampleModal"">
                                                        Eliminar
                                                    </button>

                                                    <!-- Modal -->
                                            <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog""
                                                aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                                        <div class=""modal-dialog"" role=""document"">
                                                            <div class=""modal-content"">
       ");
            WriteLiteral(@"                                                         <div class=""modal-header"">
                                                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Debes
                                                                        confirmar</h5>
                                                                    <button type=""button"" class=""close"" data-dismiss=""modal""
                                                                aria-label=""Close"">
                                                                        <span aria-hidden=""true"">&times;</span>
                                                                    </button>
                                                                </div>
                                                                <div class=""modal-body"">
                                                                    ¿Estás seguro de eliminar el cuidador?
                                                        ");
            WriteLiteral("        </div>\r\n                                                                <div class=\"modal-footer\">\r\n");
            WriteLiteral("\r\n                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c928c17833b63046ae0081811ddb52bde55ce018306", async() => {
                WriteLiteral("\r\n                                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c928c17833b63046ae0081811ddb52bde55ce018637", async() => {
                    WriteLiteral("\r\n                                                                            Sí, ¡estoy seguro!\r\n                                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idVeterinario", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                                                                                 WriteLiteral(v.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["idVeterinario"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idVeterinario", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["idVeterinario"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                    <button type=""button"" class=""btn btn-secondary""
                                                                data-dismiss=""modal"">Cancelar</button>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 117 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminMascota.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.AdminMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminMascotaModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.AdminMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
