#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e29144e5cf360bd918e7ac83a907e11be786e87"
// <auto-generated/>
#pragma warning disable 1591
namespace TreasuryExpress.Client.Pages._Balances
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Balances;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\_Imports.razor"
using TreasuryExpress.Client.Pages._Transactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/text")]
    public partial class BalanceCardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-3 col-sm-6 m-1");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ol");
            __builder.AddAttribute(4, "class", "list-group");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "list-group-item  bg-custom text-white");
            __builder.AddContent(8, "# :");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
                                                              balance.AccountId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "list-group-item  bg-custom  text-white");
            __builder.AddContent(13, "num: ");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
                                                                 balance.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "list-group-item  bg-custom text-white");
            __builder.AddContent(18, "$: ");
            __builder.AddContent(19, 
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
                                                              balance.BalanceAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "list-group-item  bg-custom  text-white-50");
            __builder.AddContent(23, "date: ");
            __builder.AddContent(24, 
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
                                                                     balance.BalanceDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\BalanceCardComponent.razor"
       
    [Parameter]
    public Balance balance { get; set; }

    [Parameter]
    public int order { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
