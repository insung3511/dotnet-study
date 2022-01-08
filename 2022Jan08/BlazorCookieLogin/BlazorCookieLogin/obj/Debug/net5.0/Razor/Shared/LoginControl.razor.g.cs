#pragma checksum "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c40deb3d49927c5359a77538a8924e8ae19af662"
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
#nullable restore
#line 2 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loginControl")]
    public partial class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "b");
                __builder2.AddContent(3, "Hello, ");
#nullable restore
#line 6 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
__builder2.AddContent(4, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, " !");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.AddMarkupContent(7, "<a class=\"ml-md-auto btn btn-primary\">\n            href=\"/logout?returnUrl=/\"\n            target=\"_top\">\n            Logout\n        </a>");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "placeholder", "User Name");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
                                                           Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n        &nbsp; &nbsp;\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "password");
                __builder2.AddAttribute(17, "placeholder", "Password");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
                                                              Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n\n        ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "class", "ml-md-auto btn btn-primary");
                __builder2.AddAttribute(23, "href", "/login?paramUsername=" + (
#nullable restore
#line 19 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
                                       encode(Username)

#line default
#line hidden
#nullable disable
                ) + "&paramPassword=" + (
#nullable restore
#line 19 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
                                                                       encode(Password)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "target", "_top");
                __builder2.AddMarkupContent(25, "\n            Login\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/bahk_insung/Projects/BlazorCookieLogin/BlazorCookieLogin/Shared/LoginControl.razor"
       
    string Username = "";
    string Password = "";
    private string encode(string param)
    {
        return HttpUtility.UrlEncode(param);
        //return param;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
