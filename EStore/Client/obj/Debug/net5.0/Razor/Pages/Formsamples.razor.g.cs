#pragma checksum "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\Pages\Formsamples.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520aa810c6e4bc94f691a10fa10aeb1ea3431a3e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Formsamples")]
    public partial class Formsamples : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"app sidebar-mini rtl\"><header class=\"app-header\"><a class=\"app-header__logo\" href=\"Index2\">Estore</a>\r\n        <a class=\"app-sidebar__toggle\" href=\"#\" data-toggle=\"sidebar\" aria-label=\"Hide Sidebar\"></a>\r\n<ul class=\"app-nav\"><li class=\"dropdown\"><a class=\"app-nav__item\" href=\"LoginDashboard\" data-toggle=\"dropdown\" aria-label=\"Open Profile Menu\"><i class=\"fa fa-user fa-lg\"></i></a>\r\n            <ul class=\"dropdown-menu settings-menu dropdown-menu-right\"><li><a class=\"dropdown-item\" href=\"LoginDashboard\"><i class=\"fa fa-sign-out fa-lg\"></i> Logout</a></li></ul></li></ul></header>\r\n    \r\n    <div class=\"app-sidebar__overlay\" data-toggle=\"sidebar\"></div>\r\n    <aside class=\"app-sidebar\"><div><p class=\"app-sidebar__user-name\"> Estore</p>\r\n            <p class=\"app-sidebar__user-designation\">Admin </p></div>\r\n\r\n        <ul class=\"app-menu\"><li><a class=\"app-menu__item active\" href=\"Index2\"><i class=\"app-menu__icon fa fa-dashboard\"></i><span class=\"app-menu__label\">Dashboard</span></a></li>\r\n\r\n\r\n\r\n            <li><a class=\"app-menu__item\" href=\"Formsamples\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-edit\"></i><span class=\"app-menu__label\"> Product</span></a></li>\r\n\r\n\r\n            <li><a class=\"app-menu__item\" href=\"Tablebasic\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\">Data</span></a></li>\r\n            <li><a class=\"app-menu__item\" href=\"Pageinvoice\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\"> Invoice</span></a></li>\r\n            <li><a class=\"app-menu__item\" href=\"Pagemailbox\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\"> Mailbox</span></a></li></ul></aside>\r\n    <main class=\"app-content\"><div class=\"app-title\"><div><h1><i class=\"fa fa-edit\"></i>  Product</h1></div>\r\n            <ul class=\"app-breadcrumb breadcrumb\"><li class=\"breadcrumb-item\"><i class=\"fa fa-home fa-lg\"></i></li>\r\n                <li class=\"breadcrumb-item\">Items</li>\r\n                <li class=\"breadcrumb-item\"><a href=\"#\"> HOME</a></li></ul></div>\r\n\r\n        <div class=\"table-responsive\"><table class=\"table\"><thead><tr><th>#</th>\r\n                        <th>Product Name</th>\r\n                        <th>Price</th>\r\n                        <th>Delete Product</th>\r\n                        <th>Update Product</th></tr></thead>\r\n                <tbody><tr><td>1</td>\r\n                        <td>ic2</td>\r\n                        <td>1700</td>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Delete\r\n                            </button></th>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Update\r\n                            </button></th></tr>\r\n                    <tr><td>2</td>\r\n                        <td>ic3</td>\r\n                        <td>2500</td>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Delete\r\n                            </button></th>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Update\r\n                            </button></th></tr>\r\n                    <tr><td>3</td>\r\n                        <td>ic4</td>\r\n                        <td>1500</td>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Delete\r\n                            </button></th>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Update\r\n                            </button></th></tr>\r\n                    <tr><td>4</td>\r\n                        <td>ic5</td>\r\n                        <td>1700</td>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Delete\r\n                            </button></th>\r\n                        <th><button type=\"submit\" class=\"success\">\r\n                                Update\r\n                            </button></th></tr></tbody></table></div></main></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591