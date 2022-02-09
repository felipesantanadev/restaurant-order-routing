#pragma checksum "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64e22485fa07d53b7961c16b5dd838bf015594b"
// <auto-generated/>
#pragma warning disable 1591
namespace RestaurantOrderRouting.WebApp.Pages
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
#nullable restore
#line 3 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
using RestaurantOrderRouting.Kitchen.Application.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
using RestaurantOrderRouting.WebApp.Components.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
using RestaurantOrderRouting.Order.Application.Commands;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/kitchens/{KithenId}/orders")]
    public partial class KitchenOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Kitchen Orders</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "nav nav-tabs");
            __builder.AddAttribute(3, "id", "myTab");
            __builder.AddAttribute(4, "role", "tablist");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", "nav-item");
            __builder.AddAttribute(7, "role", "presentation");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "nav-link" + " " + (
#nullable restore
#line 14 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                 ActivatedTabs[0]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                             () => ToggleTab(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "id", "home-tab");
            __builder.AddAttribute(12, "data-bs-toggle", "tab");
            __builder.AddAttribute(13, "data-bs-target", "#grill");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "role", "tab");
            __builder.AddAttribute(16, "aria-controls", "grill");
            __builder.AddAttribute(17, "aria-selected", "true");
            __builder.AddContent(18, "Burgers");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item");
            __builder.AddAttribute(22, "role", "presentation");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "nav-link" + " " + (
#nullable restore
#line 17 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                 ActivatedTabs[1]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                             () => ToggleTab(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "id", "profile-tab");
            __builder.AddAttribute(27, "data-bs-toggle", "tab");
            __builder.AddAttribute(28, "data-bs-target", "#fries");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "role", "tab");
            __builder.AddAttribute(31, "aria-controls", "fries");
            __builder.AddAttribute(32, "aria-selected", "false");
            __builder.AddContent(33, "Fries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item");
            __builder.AddAttribute(37, "role", "presentation");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "nav-link" + " " + (
#nullable restore
#line 20 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                 ActivatedTabs[2]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                             () => ToggleTab(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "id", "contact-tab");
            __builder.AddAttribute(42, "data-bs-toggle", "tab");
            __builder.AddAttribute(43, "data-bs-target", "#salad");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "role", "tab");
            __builder.AddAttribute(46, "aria-controls", "salad");
            __builder.AddAttribute(47, "aria-selected", "false");
            __builder.AddContent(48, "Salads");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "nav-item");
            __builder.AddAttribute(52, "role", "presentation");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "nav-link" + " " + (
#nullable restore
#line 23 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                 ActivatedTabs[3]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                             () => ToggleTab(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "id", "contact-tab");
            __builder.AddAttribute(57, "data-bs-toggle", "tab");
            __builder.AddAttribute(58, "data-bs-target", "#drink");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "role", "tab");
            __builder.AddAttribute(61, "aria-controls", "drink");
            __builder.AddAttribute(62, "aria-selected", "false");
            __builder.AddContent(63, "Drinks");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "nav-item");
            __builder.AddAttribute(67, "role", "presentation");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "nav-link" + " " + (
#nullable restore
#line 26 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                 ActivatedTabs[4]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                             () => ToggleTab(4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "id", "contact-tab");
            __builder.AddAttribute(72, "data-bs-toggle", "tab");
            __builder.AddAttribute(73, "data-bs-target", "#deserts");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "role", "tab");
            __builder.AddAttribute(76, "aria-controls", "deserts");
            __builder.AddAttribute(77, "aria-selected", "false");
            __builder.AddContent(78, "Deserts");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "tab-content");
            __builder.AddAttribute(82, "id", "myTabContent");
#nullable restore
#line 30 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
     for (int i = 0; i < Tabs.Length; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "tab-pane" + " fade" + " " + (
#nullable restore
#line 32 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                   ActivatedTabs[i]

#line default
#line hidden
#nullable disable
            ) + " justify-content-center");
            __builder.AddAttribute(85, "id", 
#nullable restore
#line 32 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                                                 Tabs[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(86, "role", "tabpanel");
            __builder.AddAttribute(87, "aria-labelledby", "home-tab");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "row");
            __builder.OpenElement(90, "table");
            __builder.AddAttribute(91, "class", "table table-striped");
            __builder.AddMarkupContent(92, @"<thead><tr><th>Order Number</th>
                            <th>Item</th>
                            <th>Received at</th>
                            <th>Status</th>
                            <th>Change status to</th></tr></thead>
                    ");
            __builder.OpenElement(93, "tbody");
#nullable restore
#line 45 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                         foreach (var item in Orders.SelectMany(x => x.OrderItems.Where(o => o.KitchenAreaName.ToLower().Equals(Tabs[i])).OrderBy(o => o.Status).ThenBy(o => o.CreationDate)))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "tr");
            __builder.AddAttribute(95, "class", 
#nullable restore
#line 47 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                         GetRowClass(item.Status)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 48 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                     item.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.OpenElement(99, "td");
            __builder.AddContent(100, 
#nullable restore
#line 49 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                     item.ItemName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                                ");
            __builder.OpenElement(102, "td");
            __builder.AddContent(103, 
#nullable restore
#line 50 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                     item.CreationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 51 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                     item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                ");
            __builder.OpenElement(108, "td");
#nullable restore
#line 53 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                     if (item.Status != Crosscutting.Enum.OrderItemStatus.Done)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<RestaurantOrderRouting.WebApp.Components.Buttons.LoadingButton>(109);
            __builder.AddAttribute(110, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                               GetNextStatus(item.Status).ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "OtherClasses", "w-100");
            __builder.AddAttribute(112, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                                                                                                                        async () => await ChangeOrderItemStatus(item.OrderId, item.OrderItemId, item.Status)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 56 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\felipe.ssilva\source\repos\RestaurantOrderRouting\RestaurantOrderRouting.WebApp\Pages\KitchenOrders.razor"
       
    [Parameter]
    public string KithenId { get; set; }

    private string[] Tabs = new string[] { "grill", "fries", "salad", "drinks", "deserts" };
    private List<string> ActivatedTabs = new List<string>()
{
        "show active", "", "", "", ""
    };

    private void ToggleTab(int index)
    {
        for (int i = 0; i < ActivatedTabs.Count; i++)
        {
            if (i == index)
                ActivatedTabs[i] = "show active";
            else
                ActivatedTabs[i] = "";
        }
    }

    private List<OrderDto> Orders = new List<OrderDto>();

    protected override async Task OnInitializedAsync()
    {
        var result = await _httpService.GetAsync<List<OrderDto>>($"{_configuration["KITCHEN_API_ENDPOINT"]}/api/kitchens/{KithenId}/orders");

        if (result.IsSuccess)
            Orders = result.ResponseResult.Result;
    }

    private static Crosscutting.Enum.OrderItemStatus GetNextStatus(Crosscutting.Enum.OrderItemStatus currentStatus)
    {
        if (currentStatus == Crosscutting.Enum.OrderItemStatus.Done)
            return currentStatus;

        var nextValue = ((int)currentStatus) + 1;
        return (Crosscutting.Enum.OrderItemStatus)nextValue;
    }

    private async Task ChangeOrderItemStatus(int orderId, int orderItemId, Crosscutting.Enum.OrderItemStatus currentStatus)
    {
        var nextStatus = GetNextStatus(currentStatus);
        var command = new UpdateOrderItemStatusCommand()
        {
            NewStatus = nextStatus,
            OrderId = orderId,
            OrderItemId = orderItemId
        };

        var result = await _httpService.PostAsync<UpdateOrderItemStatusCommand, string>($"{_configuration["ORDER_API_ENDPOINT"]}/api/orders/{orderId}/items/{orderItemId}/update-status", command);

        if (result.IsSuccess)
        {
            var item = Orders.SelectMany(x => x.OrderItems.Where(o => o.OrderItemId == orderItemId)).FirstOrDefault();
            item.Status = nextStatus;
        }
    }

    private string GetRowClass(Crosscutting.Enum.OrderItemStatus status)
    {
        return status switch
        {
            Crosscutting.Enum.OrderItemStatus.Preparing => "table-warning",
            Crosscutting.Enum.OrderItemStatus.Done => "table-success",
            Crosscutting.Enum.OrderItemStatus.Canceled => "table-danger",
            _ => string.Empty
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService _httpService { get; set; }
    }
}
#pragma warning restore 1591
