#pragma checksum "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\Pages\Tops.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fafb9878e533c37adb26e5d3bd52891fd8cef984"
// <auto-generated/>
#pragma warning disable 1591
namespace EStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tops")]
    public partial class Tops : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\"><div class=\" container d-none d-lg-block\"><div class=\"row py-3 \"><div class=\"col-lg-2 col-1 p-0 bg-white\"><div class=\"dropdown dropright\"><a class=\"btn dropdown-toggle\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                        Women\'s Fashion\r\n                    </a>\r\n                    <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton\"><a class=\"dropdown-item\" href=\"unstitchedfabric\">Unstiched Fabric</a>\r\n                        <a class=\"dropdown-item\" href=\"Kurta\"> kurtas & shalwar kameez</a>\r\n                        <a class=\"dropdown-item\" href=\"Muslimwear\">Muslim Wear</a>\r\n                        <a class=\"dropdown-item\" href=\"Tops\">Tops</a>\r\n                        <a class=\"dropdown-item\" href=\"Shoes\">Shoes</a>\r\n                        <a class=\"dropdown-item\" href=\"Watches\">Watches</a></div></div>\r\n\r\n                <div class=\"dropdown dropright\"><a class=\"btn dropdown-toggle\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                        Men\'s Fashion\r\n                    </a>\r\n                    <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton\"><a class=\"dropdown-item\" href=\"Tshirt\">T-Shirt & Tanks</a>\r\n                        <a class=\"dropdown-item\" href=\"Pjeans\"> Pants and Jeans</a>\r\n                        <a class=\"dropdown-item\" href=\"Bkurta\"> kurtas & shalwar kameez</a>\r\n                        <a class=\"dropdown-item\" href=\"Winter\">Winter Clothing</a>\r\n                        <a class=\"dropdown-item\" href=\"Bshoes\">Shoes</a>\r\n                        <a class=\"dropdown-item\" href=\"Bwatches\">Watches</a></div></div>\r\n\r\n                <div class=\"dropdown dropright\"><a class=\"btn dropdown-toggle\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                        Electronic Devices\r\n                    </a>\r\n                    <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton\"><a class=\"dropdown-item\" href=\"Phone\">Mobile Phones</a>\r\n                        <a class=\"dropdown-item\" href=\"Tabet\"> Tablets</a>\r\n                        <a class=\"dropdown-item\" href=\"Laptop\"> Laptops</a>\r\n                        <a class=\"dropdown-item\" href=\"Desktop\">Desktops</a>\r\n                        <a class=\"dropdown-item\" href=\"Swatch\">Smart Watches</a>\r\n                        <a class=\"dropdown-item\" href=\"Game\">Gamming Consoles</a></div></div></div>\r\n            <div class=\"col-10 p-0\"><div id=\"homeSlider\" class=\"carousel slide\" data-ride=\"carousel\"><ol class=\"carousel-indicators\"><li class=\"active\" data-target=\"#homeSlider\" data-slide-to=\"0\"></li>\r\n                        <li data-target=\"#homeSlider\" data-slide-to=\"1\"></li>\r\n                        <li data-target=\"#homeSlider\" data-slide-to=\"2\"></li></ol>\r\n                    <div class=\"carousel-inner\"><div class=\"carousel-item active\"><img src=\"images/top1.jpg\" class=\"d-block w-100 \" alt=\"slide1\"></div>\r\n                        <div class=\"carousel-item \"><img src=\"images/top2.jpg\" class=\"d-block w-100\" alt=\"slide2\"></div>\r\n                        <div class=\"carousel-item\"><img src=\"images/top3.jpg\" class=\"d-block w-100\" alt=\"slide2\"></div></div>\r\n                    <a href=\"#homeSlider\" class=\"carousel-control-prev\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\"></span></a>\r\n                    <a href=\"#homeSlider\" class=\"carousel-control-next\" data-slide=\"next\"><span class=\"carousel-control-next-icon\"></span></a>\r\n                    <a href=\"#homeSlider\"></a></div></div></div></div></div>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container my-3\"><hr>\r\n    <div class=\"container my-3\"><h1>Tops New Arrival</h1> \r\n        <hr>\r\n\r\n        <div class=\"row row1 my-3\"><div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top1.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp1</h5>\r\n                        <p class=\"card-text\">\r\n                            Price.\r\n                        </p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.1500</a></div></div></div>\r\n            <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top2.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp2</h5>\r\n                        <p class=\"card-text\">Price.</p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.1700</a></div></div></div>\r\n            <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top3.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp3</h5>\r\n                        <p class=\"card-text\">Price.</p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.2500</a></div></div></div>\r\n            <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top6.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp4</h5>\r\n                        <p class=\"card-text\">Price.</p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.1500</a></div></div></div>\r\n            <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top7.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp5</h5>\r\n                        <p class=\"card-text\">Price.</p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.1700</a></div></div></div>\r\n            <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/top6.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\"><h5 class=\"card-title\">tp6</h5>\r\n                        <p class=\"card-text\">Price.</p>\r\n                        <a href=\"#\" class=\"btn text-danger\">Rs.2500</a></div></div></div></div>\r\n\r\n        <button type=\"button\" class=\"btn btn-primary btn-lg d-block mx-auto my-5\">Load More Item</button></div></div>\r\n");
            __builder.OpenComponent<EStore.Client.Shared.FooterComponent>(2);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
