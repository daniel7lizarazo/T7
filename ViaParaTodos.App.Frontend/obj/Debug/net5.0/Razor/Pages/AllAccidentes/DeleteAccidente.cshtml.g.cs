#pragma checksum "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf53ae0fb42b3bc0a990760fd57e620aca79b27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ViaParaTodos.App.Frontend.Pages.AllAccidentes.Pages_AllAccidentes_DeleteAccidente), @"mvc.1.0.razor-page", @"/Pages/AllAccidentes/DeleteAccidente.cshtml")]
namespace ViaParaTodos.App.Frontend.Pages.AllAccidentes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf53ae0fb42b3bc0a990760fd57e620aca79b27", @"/Pages/AllAccidentes/DeleteAccidente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898dd024bebc0497085d545f1c23b7b027b6a277", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AllAccidentes_DeleteAccidente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf53ae0fb42b3bc0a990760fd57e620aca79b274230", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width"">
  <title>Borrar Accidente</title>
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
      margin: 20");
                WriteLiteral(@"px;
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


<div class=""container p-5 my-5 bg-dark text-white"" style=""max-width:75%"">
  <center> 
<img src=""https://agente15.camilocasas.repl.co/Icon/Alert.png"" width=""100px"">
<h1 style=""font-size: 290%;"">Eliminar Accidente</h1></center><br>
<div class=""table-responsive"">
<table class=""table table-dark table-striped"">
    <tr>
      <th>Fecha</th>
      <th>Descripción</th>
      <th>Gravedad</th>
      <th>Localización</th>
      <th>Agente</th>
    </tr>

    <tr>
");
#nullable restore
#line 95 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     foreach (var accidente in Model.accidente_localizacion_agente)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <td>");
#nullable restore
#line 97 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     Write(accidente.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 98 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     Write(accidente.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 99 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     Write(accidente.Gravedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 100 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     Write(accidente.Localizacion.Zona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 101 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
     Write(accidente.AgentesTransito.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 102 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tr>
</table>
</div>
<br>
<br>
<center> 
<h2 style=""color: orange;"">Conductores y vehiculos involucrados</h2><img src=""https://555a09f4-9568-4027-8c32-ebfc076d4978.id.repl.co/Agente/Conductor4.png"" style=""width: 15%;""><img src=""https://555a09f4-9568-4027-8c32-ebfc076d4978.id.repl.co/Agente/Vehiculo.png"" style=""width: 15%;""></center>
<div class=""table-responsive"">
<table class=""table table-dark table-striped"">
    <tr style=""color: orange;"">
    <th>Nombre</th>
    <th>Apellido</th>
    <th>Documento</th>
    <th>Placa</th>
    <th>Linea</th>
  </tr>
");
#nullable restore
#line 119 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
 foreach (var tabla in Model.listTablaVC)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n    <td>");
#nullable restore
#line 122 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
   Write(tabla.Conductores.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 123 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
   Write(tabla.Conductores.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 124 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
   Write(tabla.Conductores.NumeroDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 125 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
   Write(tabla.Vehiculos.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 126 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
   Write(tabla.Vehiculos.Linea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 128 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>\r\n<br>\r\n<center>\r\n<h3 style=\"color: greenyellow;\">Si elimina este accidente también eliminará toda esta información, está seguro que desea eliminarlo?</h3>\r\n<br><br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf53ae0fb42b3bc0a990760fd57e620aca79b2712201", async() => {
                WriteLiteral("\r\n<input type=\"hidden\" name=\"accidenteId\"");
                BeginWriteAttribute("value", " value=\"", 3915, "\"", 3941, 1);
#nullable restore
#line 136 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllAccidentes\DeleteAccidente.cshtml"
WriteAttributeValue("", 3923, Model.accidenteId, 3923, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<button class=\"btn btn-danger\"><i class=\"fas fa-trash-alt\"></i> Eliminar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf53ae0fb42b3bc0a990760fd57e620aca79b2714389", async() => {
                WriteLiteral("\r\n<button class=\"btn btn-warning\"><i class=\"fas fa-ban\"></i> Cancelar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViaParaTodos.App.Frontend.Pages.DeleteAccidenteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DeleteAccidenteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DeleteAccidenteModel>)PageContext?.ViewData;
        public ViaParaTodos.App.Frontend.Pages.DeleteAccidenteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
