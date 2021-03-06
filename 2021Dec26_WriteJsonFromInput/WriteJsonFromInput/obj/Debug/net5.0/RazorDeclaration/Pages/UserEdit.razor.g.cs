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
#line 2 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserEdit.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserEdit.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserEdit.razor"
using WriteJsonFromInput.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserEdit")]
    public partial class UserEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UserEdit.razor"
       
    private User user = new User();
    private EditContext editContext;
    private string jsonPath = @"/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/userList.json";
    private string jsonMessage = "";
    private User[] users;

    protected override void OnInitialized()
    {
        editContext = new EditContext(user);
    }

    private void onReset()
    {
        user = new User();
        editContext = new EditContext(user);
    }

    private void onValidSubmit()
    {
        jsonMessage = JsonSerializer.Serialize(user);
        using (TextWriter tw = new StreamWriter(jsonPath))
        {
            tw.WriteLine(jsonMessage);
        }
        //File.WriteAllText(jsonPath, jsonMessage);
        Console.WriteLine(jsonMessage);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
