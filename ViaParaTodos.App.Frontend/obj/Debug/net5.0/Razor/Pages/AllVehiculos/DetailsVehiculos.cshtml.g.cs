#pragma checksum "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa13d5d9ddf177c41af258ef0d71515c85f7b09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ViaParaTodos.App.Frontend.Pages.AllVehiculos.Pages_AllVehiculos_DetailsVehiculos), @"mvc.1.0.razor-page", @"/Pages/AllVehiculos/DetailsVehiculos.cshtml")]
namespace ViaParaTodos.App.Frontend.Pages.AllVehiculos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aa13d5d9ddf177c41af258ef0d71515c85f7b09", @"/Pages/AllVehiculos/DetailsVehiculos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898dd024bebc0497085d545f1c23b7b027b6a277", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AllVehiculos_DetailsVehiculos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aa13d5d9ddf177c41af258ef0d71515c85f7b093033", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width"">
  <title>Detalle Vehiculos</title>
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
      margin: 2");
                WriteLiteral(@"0px;
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
      height: -webkit-fill-available;
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
      height: -webkit-fill-available;
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
<center>
<h1 style=""font-size:6vw"">Información del vehículo</h1>
<img src=""https://555a09f4-9568-4027-8c32-ebfc076d4978.id.repl.co/Agente/Vehiculo.png"" height=""150"">
<br>
<br>
<div class=""table-responsive"">
<table class=""table table-danger table-striped"">
    <tr>
    <th>Placa</th>
    <th>Modelo</th>
    <th>Marca</th>
    <th>Linea</th>
    <th>Color</th>
  </tr>

    <tr>
    <td>");
#nullable restore
#line 94 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml"
   Write(Model.vehiculo.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 95 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml"
   Write(Model.vehiculo.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 96 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml"
   Write(Model.vehiculo.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 97 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml"
   Write(Model.vehiculo.Linea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 98 "C:\ViaParaTodos\ViaParaTodos.App\ViaParaTodos.App.Frontend\Pages\AllVehiculos\DetailsVehiculos.cshtml"
   Write(Model.vehiculo.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViaParaTodos.App.Frontend.Pages.DetailsVehiculosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DetailsVehiculosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViaParaTodos.App.Frontend.Pages.DetailsVehiculosModel>)PageContext?.ViewData;
        public ViaParaTodos.App.Frontend.Pages.DetailsVehiculosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
