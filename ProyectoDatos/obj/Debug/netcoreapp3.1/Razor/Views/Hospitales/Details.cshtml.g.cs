#pragma checksum "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e1567feaae58ecdbeed5abc0097c9b017f9cb9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospitales_Details), @"mvc.1.0.view", @"/Views/Hospitales/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1567feaae58ecdbeed5abc0097c9b017f9cb9e", @"/Views/Hospitales/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ddeedf0bdd52521318f9ab5ace6aacb722649b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospitales_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 style=\"color: forestgreen\">");
#nullable restore
#line 3 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml"
                          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2 style=\"color: dodgerblue\">");
#nullable restore
#line 4 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml"
                         Write(Model.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2 style=\"color: palevioletred\">");
#nullable restore
#line 5 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml"
                            Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2 style=\"color: orangered\">");
#nullable restore
#line 6 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml"
                        Write(Model.Camas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Nazaret\source\repos\ProyectoDatos\ProyectoDatos\Views\Hospitales\Details.cshtml"
Write(Html.ActionLink("Volver a Index", "Index", "Hospitales"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital> Html { get; private set; }
    }
}
#pragma warning restore 1591