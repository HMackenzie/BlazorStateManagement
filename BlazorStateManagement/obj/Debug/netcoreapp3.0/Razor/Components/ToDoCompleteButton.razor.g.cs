#pragma checksum "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a01110d9d132ceba3445967adf74cbf7f596696"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
using BlazorStateManagement.StateContainers;

#line default
#line hidden
    public class ToDoCompleteButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
#line 2 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
 if (isComplete)
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.OpenElement(1, "button");
            builder.AddAttribute(2, "class", "btn btn-warning");
            builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 4 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
                                                () => stateManager.ToggleComplete(index)

#line default
#line hidden
            ));
            builder.AddContent(4, "Reactivate");
            builder.CloseElement();
            builder.AddMarkupContent(5, "\r\n");
#line 5 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.OpenElement(7, "button");
            builder.AddAttribute(8, "class", "btn btn-primary");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 8 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
                                                () => stateManager.ToggleComplete(index)

#line default
#line hidden
            ));
            builder.AddContent(10, "Close");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n");
#line 9 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 13 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoCompleteButton.razor"
 
    [CascadingParameter]
    protected ToDoState.Manager stateManager { get; set; }

    [Parameter]
    protected int index { get; set; }

    [Parameter]
    protected bool isComplete { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
