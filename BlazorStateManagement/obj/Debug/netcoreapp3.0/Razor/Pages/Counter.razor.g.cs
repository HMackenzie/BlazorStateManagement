#pragma checksum "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152b58fb69d943a967e0627c5aa898517594ff93"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStateManagement.Pages
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
#line 2 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor"
using BlazorStateManagement.StateContainers;

#line default
#line hidden
#line 3 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor"
using BlazorStateManagement.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n");
            __Blazor.BlazorStateManagement.Pages.Counter.TypeInference.CreateCascadingValue_0(builder, 1, 2, 
#line 5 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor"
                       stateManager

#line default
#line hidden
            , 3, (builder2) => {
                builder2.AddMarkupContent(4, "\r\n    ");
                builder2.OpenComponent<BlazorStateManagement.Components.CounterDisplay>(5);
                builder2.AddAttribute(6, "CurrentCount", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(
#line 6 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor"
                                  state.CurrentCount

#line default
#line hidden
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(7, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#line 8 "C:\Users\harry.mackenzie\source\repos\BlazorStateManagement\BlazorStateManagement\Pages\Counter.razor"
      
    private CounterState state;
    private CounterState.Manager stateManager;
    protected override void OnInit()
    {
        state = new CounterState();
        stateManager = new CounterState.Manager(state);
        stateManager.OnCountChanged += StateHasChanged;
    }

        protected override void OnAfterRender()
        {
            base.OnAfterRender();
        }

#line default
#line hidden
    }
}
namespace __Blazor.BlazorStateManagement.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<T>(global::Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<T>>(seq);
        builder.AddAttribute(__seq0, "Value", __arg0);
        builder.AddAttribute(__seq1, "ChildContent", __arg1);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
