#pragma checksum "C:\BlazorProjects\Chap4\SampleCalculator\SampleCalculator\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fabfd6e6d002e957b53fad126e1419708789b9"
// <auto-generated/>
#pragma warning disable 1591
namespace SampleCalculator.Pages
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
    using SampleCalculator;
    using SampleCalculator.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Counter");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "Current count: ");
            builder.AddContent(5, currentCount);
            builder.CloseElement();
            builder.AddContent(6, "\n\n");
            builder.OpenElement(7, "button");
            builder.AddAttribute(8, "class", "btn btn-primary");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(IncrementCount));
            builder.AddContent(10, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\BlazorProjects\Chap4\SampleCalculator\SampleCalculator\Pages\Counter.cshtml"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
