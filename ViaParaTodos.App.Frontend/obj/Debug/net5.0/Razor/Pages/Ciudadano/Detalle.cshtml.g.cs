#pragma checksum "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0187cba165ecf84ad34728881a4a1d6f7c70a84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ViaParaTodos.App.Frontend.Pages.Ciudadano.Pages_Ciudadano_Detalle), @"mvc.1.0.razor-page", @"/Pages/Ciudadano/Detalle.cshtml")]
namespace ViaParaTodos.App.Frontend.Pages.Ciudadano
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
#line 1 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\_ViewImports.cshtml"
using ViaParaTodos.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0187cba165ecf84ad34728881a4a1d6f7c70a84", @"/Pages/Ciudadano/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898dd024bebc0497085d545f1c23b7b027b6a277", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ciudadano_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AllAccidentes/ListVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: darkmagenta;    border-color: darkmagenta;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0187cba165ecf84ad34728881a4a1d6f7c70a844213", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width"">
  <title>Eliminar Conductor</title>
  <link href=""style.css"" rel=""stylesheet"" type=""text/css"" />

   <script src=""https://kit.fontawesome.com/b4ddf1f0cb.js"" crossorigin=""anonymous""></script> 
  <!-- CSS only -->
  <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">

  <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
  <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"">

  </script>
  <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js""></script>

  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"">

  </script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"">

  </script>

  <style>
    .city {
      background-color: tomato;
      color: white;
      border: 2px solid black;
      margin: ");
                WriteLiteral(@"20px;
      padding: 50px;
      width: 70%;
      height: 100%;
      position: relative;
      display: block;
    }

    .responsive {
      max-width: 100%;
      position: relative;
      display: block;
      width: 50%;
      height: auto;
    }

    .circle {
      height: 300px;
      width: 300px;
      background-color: currentColor;
      border-radius: 50%;
    }

    .boton-barras {
      font-weight: bold;
      border-radius: 50%;
      border: none;
      color: #FFFFFF;
      text-align: center;
      font-size: 28px;
      width: 70px;
      height: 70px;
      transition: all 0.5s;
      cursor: pointer;

    }

    #grad1 {
      height: auto;
      background-color: red;
      /* For browsers that do not support gradients */
      background-image: linear-gradient(to left, black, #BD982D, #BDB42D, #FFC900, #FFEC00);
    }
  </style>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  <div class=""container p-5 my-5"" style=""max-width:75%;background-color: #ffb229;"">
  <center> 
  <img src=""https://agente15.camilocasas.repl.co/Icon/Alert.png"" width=""100px"">
<h1 style=""font-size:6vw;"">Eliminar Conductor</h1></center><br>
<div class=""table-responsive"">
<table class=""table table-warning table-striped"">
    <tr>
    <th>Nombres</th>
    <th>Apellidos</th>
    <th>Documento</th>
    <th>Tel??fono</th>
    <th>Direcci??n</th>
    </tr>
    <tr>
    <td>");
#nullable restore
#line 93 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(Model.ciudadano.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 94 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(Model.ciudadano.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 95 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(Model.ciudadano.NumeroDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 96 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(Model.ciudadano.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 97 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(Model.ciudadano.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
</table>
</div> 
<center>
<h2>Accidentes en los que se ha visto involucrado</h2>
</center>
<div class=""table-responsive"">
<table class=""table table-warning table-striped"">
    <tr>
    <th>Fecha</th>
    <th>Descripci??n</th>
    <th>Gravedad</th>
    <th>Placa</th>
    <th>Linea</th>
  </tr>
");
#nullable restore
#line 113 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
 foreach (var tabla in Model.tablavc)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n    <td>");
#nullable restore
#line 116 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(tabla.Accidente.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 117 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(tabla.Accidente.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 118 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(tabla.Accidente.Gravedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 119 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(tabla.Vehiculos.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 120 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
   Write(tabla.Vehiculos.Linea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0187cba165ecf84ad34728881a4a1d6f7c70a8410830", async() => {
                WriteLiteral("\r\n    <i class=\"fas fa-info-circle\"></i>\r\n    Detalles\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idaccidente", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
                                                                                     WriteLiteral(tabla.Accidente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idaccidente"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idaccidente", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idaccidente"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 129 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\Ciudadano\Detalle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViaParaTodos.App.Frontend.Pages.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DetalleModel>)PageContext?.ViewData;
        public ViaParaTodos.App.Frontend.Pages.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
