// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TimeTracker.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client;

#line default
#line hidden
#line 8 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client.Shared;

#line default
#line hidden
#line 9 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 10 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\Pages\TimeEntryDelete.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\Pages\TimeEntryDelete.razor"
using TimeTracker.Client.Services;

#line default
#line hidden
#line 4 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\Pages\TimeEntryDelete.razor"
           [Authorize]

#line default
#line hidden
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/time-entries/{id:long}/delete")]
    public partial class TimeEntryDelete : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 20 "C:\Users\Admin\source\repos\aspnetcore-workshop-master\aspnetcore-workshop-master\src\TimeTracker.Client\Pages\TimeEntryDelete.razor"
       
    [Parameter] public long Id { get; set; }
    private TimeEntryModel timeEntry;
    private string errorMessage;

    protected override async Task OnInitializedAsync()
    {
        await LoadTimeEntry();
    }

    private async Task LoadTimeEntry()
    {
        var url = $"time-entries/{Id}";
        timeEntry = await ApiService.GetAsync<TimeEntryModel>(url);
    }

    private async Task DeleteTimeEntry()
    {
        if (await ApiService.DeleteAsync($"time-entries/{timeEntry.Id}"))
        {
            NavigationManager.NavigateTo("/time-entries");
        }
        else
        {
            errorMessage = "Error saving time entry";
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
