#pragma checksum "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\Shared\ProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d959b9b4e63f6446fd3a2008634bde15d6f9617c"
// <auto-generated/>
#pragma warning disable 1591
namespace EStore.Client.Shared
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
    public partial class ProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Clothes Specials</h1> \r\n");
            __builder.AddMarkupContent(1, "<div id=\"products\" class=\"carousel slide\" data-ride=\"carousel\"><div class=\"carousel-inner\"><div class=\"carousel-item active\"><div class=\"row\"><div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/17.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic1</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.1500</a></div></div></div>\r\n                <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/12.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic2</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.1700</a></div></div></div>\r\n                <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/13.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic3</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.2500</a></div></div></div>\r\n                <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/14.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic4</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.1500</a></div></div></div>\r\n                <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/16.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic5</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.1700</a></div></div></div>\r\n                <div class=\"col-lg-2 col-4 d-inline-block products\"><div class=\"card\" style=\"width: 11rem;\"><img src=\"images/17.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\"><h5 class=\"card-title\">ic6</h5>\r\n                            <p class=\"card-text\">Price.</p>\r\n                            <a href=\"#\" class=\"btn text-danger\">Rs.2500</a></div></div></div></div></div>\r\n        \r\n\r\n\r\n\r\n\r\n        \r\n        \r\n\r\n\r\n        \r\n            \r\n            <a href=\"#products\" class=\"carousel-control-prev\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\"></span></a>\r\n            <a href=\"#products\" class=\"carousel-control-next\" data-slide=\"next\"><span class=\"carousel-control-next-icon\"></span></a>\r\n            <a href=\"#products\"></a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
