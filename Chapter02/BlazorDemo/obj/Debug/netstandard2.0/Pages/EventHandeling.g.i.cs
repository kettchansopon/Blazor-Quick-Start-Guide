#pragma checksum "C:\BlazorProjects\Chap2\BlazorDemo\Pages\EventHandeling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307260852fa0fdd4330811f673885f5d0679215b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorDemo;
    using BlazorDemo.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/eventhandeling")]
    public class EventHandeling : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 20 "C:\BlazorProjects\Chap2\BlazorDemo\Pages\EventHandeling.cshtml"
           

    string Gender { get; set; }

    void ButtonClicked(UIMouseEventArgs e)
    {
        Console.WriteLine("button clicked");
    }

    void SelectGender(UIChangeEventArgs e)
    {
        Gender = e.Value.ToString();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
