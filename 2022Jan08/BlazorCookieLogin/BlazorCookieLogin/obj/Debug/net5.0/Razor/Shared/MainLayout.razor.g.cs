#pragma checksum "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b325ab04acad502b6a50a12194d53f5b07d59729"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCookieLogin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using BlazorCookieLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/_Imports.razor"
using BlazorCookieLogin.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-o3oqpe7xwn");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-o3oqpe7xwn");
            __builder.OpenComponent<BlazorCookieLogin.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-o3oqpe7xwn");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-o3oqpe7xwn");
            __builder.OpenComponent<BlazorCookieLogin.Shared.LoginControl>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-o3oqpe7xwn>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-o3oqpe7xwn");
#nullable restore
#line 14 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/MainLayout.razor"
__builder.AddContent(21, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
