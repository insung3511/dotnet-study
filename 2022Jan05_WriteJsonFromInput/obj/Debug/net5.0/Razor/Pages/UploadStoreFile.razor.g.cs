#pragma checksum "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b804b738135847d18999acd704ceb9a1ef4af062"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Blazor Server File upload (store on server)</h1>\n");
            __builder.OpenElement(1, "code");
#nullable restore
#line 10 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
__builder.AddContent(2, DefaultMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "code");
#nullable restore
#line 11 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
__builder.AddContent(5, jsonMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenElement(7, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "EditContext", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 14 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                            editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                                         onValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        \n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddMarkupContent(17, "<p>Available upload file type list : .mp4 .avi .mov .wmv</p>\n            ");
                __builder2.AddMarkupContent(18, "<p>And also please upload only video file. It could be got some error.</p>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(19);
                __builder2.AddAttribute(20, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 21 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                 OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n\n        \n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddMarkupContent(23, "<label>게시물 제목 : </label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                     blog.BlogTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogTitle = __value, blog.BlogTitle))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => blog.BlogTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n            ");
                __Blazor.WriteJsonFromInput.Pages.UploadStoreFile.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 28 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                      ()=>blog.BlogTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n\n        \n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddMarkupContent(33, "<label>게시물 설명 : </label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                     blog.BlogSubTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogSubTitle = __value, blog.BlogSubTitle))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => blog.BlogSubTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n            ");
                __Blazor.WriteJsonFromInput.Pages.UploadStoreFile.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 35 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                      ()=>blog.BlogSubTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n\n        \n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddMarkupContent(43, "<label>과제 유무 : </label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(44);
                __builder2.AddAttribute(45, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                         blog.BlogHomework

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogHomework = __value, blog.BlogHomework))));
                __builder2.AddAttribute(47, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => blog.BlogHomework));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n            ");
                __Blazor.WriteJsonFromInput.Pages.UploadStoreFile.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 42 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                                      ()=>blog.BlogHomework

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n\n        ");
                __builder2.AddMarkupContent(52, "<div class=\"text-center\"><button type=\"submit\" class=\"btn btn-primary mr-1\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n");
            __builder.OpenElement(54, "div");
            __builder.OpenElement(55, "video");
            __builder.AddAttribute(56, "controls");
            __builder.AddAttribute(57, "width", "250");
            __builder.OpenElement(58, "source");
            __builder.AddAttribute(59, "src", 
#nullable restore
#line 53 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
                      filePath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n        Sorry, your broswer doesn\'t support embedded videos.\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/UploadStoreFile.razor"
       
    string DefaultMessage = "No file(s) selected";
    IReadOnlyList<IBrowserFile> selectedFiles;
    private int maxFileSize = 1024 * 45;
    private Blog blog = new Blog();
    private EditContext editContext { get; set; }
    private string jsonPath = @"wwwroot/Data/boardList.json";
    private string jsonMessage = "";
    private string ContentWrite = "";
    private bool fileUploadSuccess = false;
    private int fileCount = 0;
    private string filePath = "";

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
        foreach (var file in selectedFiles)
        {
            Stream stream = file.OpenReadStream(maxAllowedSize: 1073741824000);
            var path = $"{env.WebRootPath}//UploadedData//{file.Name}";
            filePath = path.ToString();
            FileStream fs = File.Create(path);

            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
            fileUploadSuccess = true;
        }

        DefaultMessage = $"{selectedFiles.Count} file(s) uploaded on server";
        this.StateHasChanged();

        if (fileUploadSuccess)
        {
            blog.BlogCreatedTime = DateTime.UtcNow;
            blog.BlogId = 0;
            blog.Uploaded = true;
            blog.FileCount = fileCount;
            jsonMessage = JsonSerializer.Serialize(blog);
            using (TextWriter tw = new StreamWriter(jsonPath))
            {
                tw.WriteLine(jsonMessage);
            }
        }

        else
        {
            blog.Uploaded = false;
            DefaultMessage = "Sorry. Somthing problem with file upload and input things. Try again or contact to admin";
            jsonMessage = JsonSerializer.Serialize(blog);
            using (TextWriter tw = new StreamWriter(jsonPath))
            {
                tw.WriteLine(jsonMessage);
            }
        }
    }


    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles(maxFileSize);
        DefaultMessage = $"{selectedFiles} file(s) selected";
        this.StateHasChanged();
        fileCount = e.FileCount;
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
namespace __Blazor.WriteJsonFromInput.Pages.UploadStoreFile
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591