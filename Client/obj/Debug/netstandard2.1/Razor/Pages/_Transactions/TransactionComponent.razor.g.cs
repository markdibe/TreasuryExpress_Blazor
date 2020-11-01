#pragma checksum "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e6ee1e4d371af63b03597526b75893e1a39596b"
// <auto-generated/>
#pragma warning disable 1591
namespace TreasuryExpress.Client.Pages._Transactions
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
#line 2 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
using TreasuryExpress.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactionmanager/{accountId:int}")]
    public partial class TransactionComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
 if (accountId != default)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TreasuryExpress.Client.Pages._Transactions.TransactionFormComponent>(0);
            __builder.AddAttribute(1, "AccountId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                                            accountId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "HandleChangeDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                                                                         HandleChangeDate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "HandleSaveTransaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TreasuryExpress.Shared.Transaction>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TreasuryExpress.Shared.Transaction>(this, 
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                                                                                                                  HandleSaveTransaction

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(4, (__value) => {
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                transactionForm = (TreasuryExpress.Client.Pages._Transactions.TransactionFormComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.OpenComponent<TreasuryExpress.Client.Pages._Transactions.TransactionListComponent>(6);
            __builder.AddAttribute(7, "AccountId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                                             accountId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "HandleEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TreasuryExpress.Shared.Transaction>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TreasuryExpress.Shared.Transaction>(this, 
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                                                                    HandleEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(9, (__value) => {
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
                                transactionTable = (TreasuryExpress.Client.Pages._Transactions.TransactionListComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 11 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
}
else
{
    manager.NavigateTo("accountmanager");
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\TreasuryExpress\TreasuryExpress\Client\Pages\_Transactions\TransactionComponent.razor"
      
    #region normal Parameters
    [Parameter]
    public int accountId { get; set; }
    #endregion

    #region Object References
    private TransactionFormComponent transactionForm;

    private TransactionListComponent transactionTable;
    #endregion

    #region gathering event callback 
    private async Task HandleChangeDate(DateTime transactionDate)
    {
        await transactionTable.FilterTransactions(transactionDate);
    }

    private void HandleSaveTransaction(Transaction transaction)
    {
        transactionTable.AddTransaction(transaction);
    }

    private Task HandleEdit(Transaction tr)
    {
        Task s = Task.Run(()=> transactionForm.Edit(tr));
        return s;
    }

    #endregion


    #region component lifecycle
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }
    #endregion




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager manager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
