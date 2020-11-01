#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669873d79083597243c7df4f6cdefe72b044367c"
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
#line 1 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    public partial class OneBalanceComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "list-group-item active");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
     if (balance == null || balance == default)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<span class=\"text-center oi oi-loop-circular\"> </span>\r\n");
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "text-center");
            __builder.AddContent(8, 
#nullable restore
#line 11 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
                                balance.BalanceAmount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "p");
            __builder.AddAttribute(12, "class", "text-center");
            __builder.AddContent(13, 
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
                                balance.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Balances\OneBalanceComponent.razor"
       
    [Parameter]
    public int AccountId { get; set; }

    [Parameter]
    public DateTime DayDate { get; set; }

    private Balance balance { get; set; }


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        balance = new Balance();
        await GetBalance();
    }

    private async Task GetBalance()
    {
        string d = DayDate.ToString("dd-MM-yyyy");
        var result =  await http.GetFromJsonAsync<Balance>($"Balances/{AccountId}/{d}");
        balance = result;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
