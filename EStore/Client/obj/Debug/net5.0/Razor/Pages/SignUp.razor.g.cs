#pragma checksum "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d0bac4c90d01421cacb3c2f68d03efbbab7fd1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\"><div class=\"row\"><div class=\"col-8 mx-auto my-3 bg-white p-3\"><h1 class=\"text-center text-dark text-uppercase\">Sign up Here</h1>\r\n                <div class=\"row my-3 ml-2\"><div class=\"col-12\"><form action><div class=\"row my-3\"><div class=\"col\"><label for=\"Name\" class=\"form-label\">Name</label>\r\n                                    <input type=\"text\" class=\"form-control\"></div>\r\n                                <div class=\"col\"><label for=\"DOB\" class=\"form-label\">DOB</label>\r\n                                    <input type=\"date\" class=\"form-control\"></div></div>\r\n                            <div class=\"row my-3\"><div class=\"col\"><label for=\"Email\" class=\"form-label\">Email</label>\r\n                                    <input type=\"Email\" class=\"form-control\"></div>\r\n                                <div class=\"col\"><label for class=\"form-label\">Gender</label><br>\r\n                                    <div class=\"form-check form-check-inline\"><input class=\"form-check-input\" type=\"radio\" id=\"inlineCheckbox1\" value=\"option1\">\r\n                                        <label class=\"form-check-label\" for=\"inlineCheckbox1\">Male</label></div>\r\n                                    <div class=\"form-check form-check-inline\"><input class=\"form-check-input\" type=\"radio\" id=\"inlineCheckbox2\" value=\"option2\">\r\n                                        <label class=\"form-check-label\" for=\"inlineCheckbox2\">Female</label></div>\r\n                                    <div class=\"form-check form-check-inline\"><input class=\"form-check-input\" type=\"radio\" id=\"inlineCheckbox3\" value=\"option3\">\r\n                                        <label class=\"form-check-label\" for=\"inlineCheckbox3\">Other</label></div></div></div>\r\n\r\n                            <div class=\"row my-3\"><div class=\"col\"><label for=\"Password\" class=\"form-label\">Password</label>\r\n                                    <input type=\"password\" class=\"form-control\"></div>\r\n                                <div class=\"col\"><label for=\"ConfirmPassword\" class=\"form-label\">Confirm Password</label>\r\n                                    <input type=\"password\" class=\"form-control\"></div></div>\r\n                            <button type=\"submit\" class=\"btn col-6 bg-success m-auto text-white d-block\">\r\n                                Create\r\n                                Account\r\n                            </button></form>\r\n                        <hr>\r\n                        <h5 class=\"text-center\">Or Create account With</h5>\r\n                        <p class=\"btn d-inline-block col-3 ml-5 my-3 text-white\" style=\"background-color: #3B5998;\"><i class=\"fa fa-facebook-official font-weight-bold\" aria-hidden=\"true\"></i> FaceBook\r\n                        </p>\r\n                        <p class=\"btn d-inline-block col-3 mx-auto my-3 text-white\" style=\"background-color: #d34836;\"><i class=\"fa fa-google font-weight-bold\" aria-hidden=\"true\"></i> Google\r\n                        </p>\r\n                        <p class=\"btn d-inline-block col-3 mx-auto my-3 text-white\" style=\"background-color: #1DA1F2;\"><i class=\"fa fa-twitter font-weight-bold\" aria-hidden=\"true\"></i> Twitter\r\n                        </p></div></div></div></div></div>\r\n    ");
            __builder.OpenComponent<EStore.Client.Shared.FooterComponent>(1);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
