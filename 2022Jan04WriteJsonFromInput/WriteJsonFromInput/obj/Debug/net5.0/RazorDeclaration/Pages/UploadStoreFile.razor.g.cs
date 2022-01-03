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
#line 2 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
using WriteJsonFromInput.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UploadStoreFile")]
    public partial class UploadStoreFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
       
    string DefaultMessage = "No file(s) selected";
    IReadOnlyList<IBrowserFile> selectedFiles;
    private int maxFileSize = 1024 * 45;
    private Blog blog = new Blog();
    private EditContext editContext { get; set; }
    private string jsonPath = @"wwwroot/Data/boardList.json";
    private string jsonMessage = "";
    private string ContentWrite = "";

    protected override void OnInitialized()
    {
        editContext = new EditContext(blog);
    }

    private void onReset()
    {
        editContext = new EditContext(blog);
    }

    private async void onValidSubmit()
    {
        blog.BlogCreatedTime = DateTime.UtcNow;
        blog.BlogId = 0;
        //Console.WriteLine(ContentWrite);
        jsonMessage = JsonSerializer.Serialize(blog);
        using (TextWriter tw = new StreamWriter(jsonPath))
        {
            tw.WriteLine(jsonMessage);
        }
        //Console.WriteLine(jsonMessage);

        foreach (var file in selectedFiles)
        {
            Stream stream = file.OpenReadStream();
            var path = $"{env.WebRootPath}//UploadedData//{file.Name}";
            FileStream fs = File.Create(path);

            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        }

        DefaultMessage = $"{selectedFiles.Count} file(s) uploaded on server";
        this.StateHasChanged();
    }


    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles(maxFileSize);
        DefaultMessage = $"{selectedFiles} file(s) selected";
        this.StateHasChanged();
    }

    private async void OnSubmit()
    {
        foreach (var file in selectedFiles)
        {
            Stream stream = file.OpenReadStream();
            var path = $"{env.WebRootPath}//UploadedData//{file.Name}";
            FileStream fs = File.Create(path);

            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        }

        DefaultMessage = $"{selectedFiles.Count} file(s) uploaded on server";
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
#pragma warning restore 1591
