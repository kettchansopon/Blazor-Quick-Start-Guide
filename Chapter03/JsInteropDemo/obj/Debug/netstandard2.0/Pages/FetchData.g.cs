#pragma checksum "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd590ee76ed13b8f898804b9ecfc6963a9df5e1b"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Weather forecast");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "This component demonstrates fetching data from the server.");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
#line 8 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.OpenElement(7, "p");
            builder.OpenElement(8, "em");
            builder.AddContent(9, "Loading...");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(10, "\n");
#line 11 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(11, "    ");
            builder.OpenElement(12, "table");
            builder.AddAttribute(13, "class", "table");
            builder.AddContent(14, "\n        ");
            builder.OpenElement(15, "thead");
            builder.AddContent(16, "\n            ");
            builder.OpenElement(17, "tr");
            builder.AddContent(18, "\n                ");
            builder.OpenElement(19, "th");
            builder.AddContent(20, "Date");
            builder.CloseElement();
            builder.AddContent(21, "\n                ");
            builder.OpenElement(22, "th");
            builder.AddContent(23, "Temp. (C)");
            builder.CloseElement();
            builder.AddContent(24, "\n                ");
            builder.OpenElement(25, "th");
            builder.AddContent(26, "Temp. (F)");
            builder.CloseElement();
            builder.AddContent(27, "\n                ");
            builder.OpenElement(28, "th");
            builder.AddContent(29, "Summary");
            builder.CloseElement();
            builder.AddContent(30, "\n            ");
            builder.CloseElement();
            builder.AddContent(31, "\n        ");
            builder.CloseElement();
            builder.AddContent(32, "\n        ");
            builder.OpenElement(33, "tbody");
            builder.AddContent(34, "\n");
#line 24 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(35, "                ");
            builder.OpenElement(36, "tr");
            builder.AddContent(37, "\n                    ");
            builder.OpenElement(38, "td");
            builder.AddContent(39, forecast.Date.ToShortDateString());
            builder.CloseElement();
            builder.AddContent(40, "\n                    ");
            builder.OpenElement(41, "td");
            builder.AddContent(42, forecast.TemperatureC);
            builder.CloseElement();
            builder.AddContent(43, "\n                    ");
            builder.OpenElement(44, "td");
            builder.AddContent(45, forecast.TemperatureF);
            builder.CloseElement();
            builder.AddContent(46, "\n                    ");
            builder.OpenElement(47, "td");
            builder.AddContent(48, forecast.Summary);
            builder.CloseElement();
            builder.AddContent(49, "\n                ");
            builder.CloseElement();
            builder.AddContent(50, "\n");
#line 32 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
            }

#line default
#line hidden
            builder.AddContent(51, "        ");
            builder.CloseElement();
            builder.AddContent(52, "\n    ");
            builder.CloseElement();
            builder.AddContent(53, "\n");
#line 35 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 37 "C:\BlazorProjects\Chap3\JsInteropDemo\Pages\FetchData.cshtml"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
