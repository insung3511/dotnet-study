#pragma checksum "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cc9a60d82e122df9d610dee27d6dcdfd6528393"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCookieLogin.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<BlazorCookieLogin.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591