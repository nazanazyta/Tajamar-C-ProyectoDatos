#pragma checksum "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aa82442a357d4ed4daba8faaec485db68a1f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospitales_Index), @"mvc.1.0.view", @"/Views/Hospitales/Index.cshtml")]
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
#line 1 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\_ViewImports.cshtml"
using ProyectoDatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\_ViewImports.cshtml"
using ProyectoDatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93aa82442a357d4ed4daba8faaec485db68a1f0b", @"/Views/Hospitales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ddeedf0bdd52521318f9ab5ace6aacb722649b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospitales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hospital>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hospitales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1 style=\"color: dodgerblue\">Lista de Hospitales SQL Server</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93aa82442a357d4ed4daba8faaec485db68a1f0b3797", async() => {
                WriteLiteral("Nuevo hospital");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
Write(Html.ActionLink("Eliminar hospital", "Delete", "Hospitales"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 7 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
 foreach (Hospital h in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>\r\n        ");
#nullable restore
#line 10 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
   Write(h.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        <small>");
#nullable restore
#line 11 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
          Write(Html.ActionLink("Detalles", "Details", "Hospitales", new { idhosp = h.IdHospital }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        <small>");
#nullable restore
#line 12 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
          Write(Html.ActionLink("Editar", "Edit", "Hospitales", new { idhospi = h.IdHospital }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n    </h3>\r\n");
#nullable restore
#line 14 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hospital>> Html { get; private set; }
    }
}
#pragma warning restore 1591
