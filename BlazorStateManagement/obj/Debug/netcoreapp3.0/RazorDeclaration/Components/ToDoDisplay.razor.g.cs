#pragma checksum "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8863ea2f7530549017c0add7be1f952616e349dc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorStateManagement.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using BlazorStateManagement;

#line default
#line hidden
#line 8 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using BlazorStateManagement.Shared;

#line default
#line hidden
#line 1 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
using BlazorStateManagement.Data;

#line default
#line hidden
#line 2 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
using BlazorStateManagement.Components;

#line default
#line hidden
#line 3 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
using BlazorStateManagement.StateContainers;

#line default
#line hidden
    public class ToDoDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 32 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
       
    [Parameter]
    protected List<ToDoItem> ToDoItems { get; set; }

    [CascadingParameter]
    protected ToDoState.Manager stateManager { get; set; }

    public ToDoItem NewItem { get; set; }

    protected override void OnInit()
    {
        this.NewItem = new ToDoItem();
    }

    public void HandleAddClick()
    {
        stateManager.AddItem(NewItem);
        NewItem = new ToDoItem();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591