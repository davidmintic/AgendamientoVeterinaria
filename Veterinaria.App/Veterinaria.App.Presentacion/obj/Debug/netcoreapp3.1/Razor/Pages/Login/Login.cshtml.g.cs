#pragma checksum "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b13345a8cabae2fff53c0df690c472942163819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Login.Pages_Login_Login), @"mvc.1.0.razor-page", @"/Pages/Login/Login.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Login
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b13345a8cabae2fff53c0df690c472942163819", @"/Pages/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<img src=\".././images/bg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 95, "\"", 101, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"cls-bg-login\">\r\n\r\n<div class=\"cls-container-login\">\r\n\r\n  <img src=\".././images/huella.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 200, "\"", 206, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"cls-bg-huella\">\r\n  <div class=\"container cls-sub-container-login\">\r\n\r\n    <div class=\"row d-flex justify-content-center mb-4\">\r\n      <h4>");
#nullable restore
#line 15 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Login\Login.cshtml"
     Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13345a8cabae2fff53c0df690c4729421638195899", async() => {
                WriteLiteral(@"

      <div class=""row"">
        <div class=""col"">
          <div class=""form-group"">
            <label for=""id-correo"">Correo:</label>
            <input required type=""email"" class=""form-control"" id=""id-correo"" aria-describedby=""emailHelp"" name=""Correo""
              placeholder=""Escribe aquí tu correo"" autocomplete=""off"">
");
                WriteLiteral(@"          </div>
        </div>
      </div>

      <div class=""row"">
        <div class=""col"">
          <div class=""form-group"">
            <label for=""id-contrasenia"">Contraseña:</label>
            <input required type=""password"" class=""form-control"" id=""id-contrasenia"" name=""Contrasenia""
              placeholder=""Escribe aquí tu contraseña"">
          </div>
        </div>
      </div>

      <div class=""row"">
        <div class=""col d-flex justify-content-center"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b13345a8cabae2fff53c0df690c4729421638197074", async() => {
                    WriteLiteral("Entrar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n      </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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



    <div class=""row d-flex mt-2"">
      <div class=""col text-center"">
        <a href=""#"" class=""link-primary"">¿Eres nuevo? Regístrate</a>
      </div>
    </div>

    <div class=""row d-flex mt-2"">
      <div class=""col text-center"">
        <a href=""#"" class=""link-primary"">¿Olvidaste tu contraseña?</a>
      </div>
    </div>
  </div>
</div>


");
#nullable restore
#line 67 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Login\Login.cshtml"
 if (Model.errorLogin)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <div aria-live=""polite"" aria-atomic=""true"" 
  style=""min-height: 200px; position: absolute; top: 50%; left: 50%; z-index: 99; width: 300px; transform: translateX(-50%);"">
    <div class=""toast"" style=""position: absolute; top: 0; right: 0; opacity: 1 !important;"">
      <div class=""toast-header"">
");
            WriteLiteral(@"        <strong class=""mr-auto"">Error iniciando sesión</strong>
        <small>.....</small>
        <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""toast-body"">
        Intenta nuevamente
      </div>
    </div>
  </div>
");
#nullable restore
#line 85 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\AgendamientoVeterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Login\Login.cshtml"
}








#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.LoginModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
