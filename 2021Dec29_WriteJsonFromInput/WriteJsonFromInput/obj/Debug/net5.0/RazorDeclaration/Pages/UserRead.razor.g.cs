// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WriteJsonFromInput.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using WriteJsonFromInput;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/_Imports.razor"
using WriteJsonFromInput.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
using WriteJsonFromInput.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
using System.Text.Unicode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserRead")]
    public partial class UserRead : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserRead.razor"
       
    User user = new User();
    string jsonFile = File.ReadAllText(@"wwwroot/userList.json");

    protected override void OnInitialized()
    {
        user = JsonSerializer.Deserialize<User>(jsonFile);
    }

    public class Users
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfTime { get; set; }
        public string Email { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
