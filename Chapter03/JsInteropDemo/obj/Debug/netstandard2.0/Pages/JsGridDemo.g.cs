#pragma checksum "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\JsGridDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbaf1fe86a8fef8ca13bedc083f7df4ea1d7af7e"
// <auto-generated/>
#pragma warning disable 1591
namespace JsInteropDemo.Pages
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
    using JsInteropDemo;
    using JsInteropDemo.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/jsgriddemo")]
    public class JsGridDemo : JsGridDemoModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Display data using JS Grid");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "hr");
            builder.CloseElement();
            builder.AddContent(4, "\n\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ShowGrid));
            builder.AddContent(8, "Show Grid");
            builder.CloseElement();
            builder.AddContent(9, "\n");
            builder.OpenElement(10, "br");
            builder.CloseElement();
            builder.AddContent(11, "\n");
            builder.OpenElement(12, "br");
            builder.CloseElement();
            builder.AddContent(13, "\n");
            builder.OpenElement(14, "div");
            builder.AddAttribute(15, "id", "dataGrid");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
