#pragma checksum "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db04573bbbb8ec8e61a2bc2d2ee6056825a1b76"
// <auto-generated/>
#pragma warning disable 1591
namespace RestaurantOrderRouting.WebApp.Components.Alerts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using RestaurantOrderRouting.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using RestaurantOrderRouting.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\_Imports.razor"
using RestaurantOrderRouting.WebApp.Services.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class Alert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor"
 if (!string.IsNullOrEmpty(Message))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert" + " alert-" + (
#nullable restore
#line 3 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor"
                             MessageClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Components\Alerts\Alert.razor"
       
    [Parameter]
    public string Message { get; set; } = string.Empty;
    [Parameter]
    public string MessageClass { get; set; } = "danger";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591