#pragma checksum "C:\BlazorProjects\Chap2\BlazorDemo\Pages\CompDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971506465472e1843a95a028b38bf3fbbd614405"
// <auto-generated/>
#pragma warning disable 1591
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/singlepagecomp")]
    public class CompDemo : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, PageTitle);
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "hr");
            builder.CloseElement();
            builder.AddContent(4, "\n");
            builder.OpenElement(5, "p");
            builder.AddContent(6, "This component is created using a single .cshtml page.");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\BlazorProjects\Chap2\BlazorDemo\Pages\CompDemo.cshtml"
            
string PageTitle = "Component Demo";

#line default
#line hidden
    }
}
#pragma warning restore 1591
