#pragma checksum "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f4e6f5c9933c72c3b3e82b686c04525636795c"
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
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
using BlazorStateManagement;

#line default
#line hidden
#line 7 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\_Imports.razor"
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
#line 5 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
 if (ToDoItems != null || !ToDoItems.Any())
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.OpenElement(1, "table");
            builder.AddAttribute(2, "class", "table");
            builder.AddMarkupContent(3, "\r\n        ");
            builder.AddMarkupContent(4, "<thead>\r\n            <tr>\r\n                <th>Task</th>\r\n                <th>Finished?</th>\r\n                <th>Options</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(5, "tbody");
            builder.AddMarkupContent(6, "\r\n");
#line 16 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
             for (var i = 0; i < ToDoItems.Count(); i++)
            {

#line default
#line hidden
            builder.AddContent(7, "                ");
            builder.OpenElement(8, "tr");
            builder.AddMarkupContent(9, "\r\n                    ");
            builder.OpenElement(10, "td");
            builder.AddContent(11, 
#line 19 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                         ToDoItems.ElementAt(i).Text

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(12, "\r\n                    ");
            builder.OpenElement(13, "td");
            builder.AddContent(14, 
#line 20 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                         ToDoItems.ElementAt(i).IsComplete.ToString()

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n                    ");
            builder.OpenElement(16, "td");
            builder.OpenComponent<BlazorStateManagement.Components.ToDoCompleteButton>(17);
            builder.AddAttribute(18, "index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 21 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                                                   i

#line default
#line hidden
            ));
            builder.AddAttribute(19, "isComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                                                                  ToDoItems.ElementAt(i).IsComplete

#line default
#line hidden
            ));
            builder.CloseComponent();
            builder.AddContent(20, " ");
            builder.CloseElement();
            builder.AddMarkupContent(21, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n");
#line 23 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
            }

#line default
#line hidden
            builder.AddContent(23, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(24, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n");
#line 26 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(26, " ");
            builder.AddMarkupContent(27, "<p><em>Doesn\'t look like there\'s any ToDo Items yet. Try adding one!</em></p>");
#line 28 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                                                                               }

#line default
#line hidden
            builder.AddMarkupContent(28, "\r\n");
            builder.OpenElement(29, "input");
            builder.AddAttribute(30, "type", "text");
            builder.AddAttribute(31, "class", "form-control");
            builder.AddAttribute(32, "placeholder", "Details");
            builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 30 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                                                                           NewItem.Text

#line default
#line hidden
            ));
            builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewItem.Text = __value, NewItem.Text));
            builder.SetUpdatesAttributeName("value");
            builder.CloseElement();
            builder.AddMarkupContent(35, "\r\n");
            builder.OpenElement(36, "button");
            builder.AddAttribute(37, "type", "button");
            builder.AddAttribute(38, "class", "btn btn-success");
            builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 31 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
                                                        HandleAddClick

#line default
#line hidden
            ));
            builder.AddContent(40, "Add");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Components\ToDoDisplay.razor"
       
    [Parameter]
    protected List<ToDoItem> ToDoItems { get; set; }

    [CascadingParameter]
    protected ToDoState.Manager stateManager { get; set; }

    public ToDoItem NewItem { get; set; }

    protected override void OnInitialized()
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
