#pragma checksum "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d1a7b0e49afdd5916e9383cb153d7a7637dd2f"
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
#line 2 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
using WriteJsonFromInput.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WriteBoard")]
    public partial class WriteBoard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>WriteBlog Page</h3>\n\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "label");
            __builder.AddMarkupContent(3, "<p>Upload File here : </p>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(4);
            __builder.AddAttribute(5, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 23 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                              LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenElement(8, "div");
            __builder.OpenElement(9, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "EditContext", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 28 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 28 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                                       onReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 28 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                                                                onValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n            \n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddMarkupContent(20, "<label>게시물 제목 : </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                         blog.BlogTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogTitle = __value, blog.BlogTitle))));
                __builder2.AddAttribute(24, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => blog.BlogTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n                ");
                __Blazor.WriteJsonFromInput.Pages.WriteBoard.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 35 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                          ()=>blog.BlogTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n\n            \n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "<label>게시물 설명 : </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                         blog.BlogSubTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogSubTitle = __value, blog.BlogSubTitle))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => blog.BlogSubTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n                ");
                __Blazor.WriteJsonFromInput.Pages.WriteBoard.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 42 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                          ()=>blog.BlogSubTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n\n            \n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddMarkupContent(40, "<label>과제 유무 : </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(41);
                __builder2.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                             blog.BlogHomework

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blog.BlogHomework = __value, blog.BlogHomework))));
                __builder2.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => blog.BlogHomework));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                ");
                __Blazor.WriteJsonFromInput.Pages.WriteBoard.TypeInference.CreateValidationMessage_2(__builder2, 46, 47, 
#nullable restore
#line 49 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
                                          ()=>blog.BlogHomework

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n\n            ");
                __builder2.AddMarkupContent(49, "<div class=\"text-center\"><button type=\"submit\" class=\"btn btn-primary mr-1\">Submit</button>\n                <button type=\"reset\" class=\"btn btn-secondary\">Reset</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n\n");
            __builder.OpenElement(51, "code");
#nullable restore
#line 60 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
__builder.AddContent(52, jsonMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "/Users/bahk_insung/Projects/WriteJsonFromInput/WriteJsonFromInput/Pages/WriteBoard.razor"
       
    private Blog blog = new Blog();
    private double fileSize { get; set; }
    private string ImageDataURL { get; set; }
    private string ContentWrite { get; set; }
    private EditContext editContext { get; set; }
    private string jsonPath = @"wwwroot/Data/boardList.json";
    private string jsonMessage = "";

    protected override void OnInitialized()
    {
        editContext = new EditContext(blog);
    }

    private void onReset()
    {
        editContext = new EditContext(blog);
    }

    private void onValidSubmit()
    {
        blog.BlogCreatedTime = DateTime.UtcNow;
        blog.BlogId = 0;
        Console.WriteLine(ContentWrite);
        jsonMessage = JsonSerializer.Serialize(blog);
        using (TextWriter tw = new StreamWriter(jsonPath))
        {
            tw.WriteLine(jsonMessage);
        }
        Console.WriteLine(jsonMessage);
    }

    // Blazor server file upload (referece from docs.microsoft.com
    private List<IBrowserFile> loadedFiles = new();
    private long maxFileSize = 1073741824000;
    private int maxAllowedFiles = 1;
    private bool isLoading;

    private async Task LoadFiles(InputFileChangeEventArgs e)
    {
        isLoading = true;
        loadedFiles.Clear();

        foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
        {
            try
            {
                loadedFiles.Add(file);

                var trustedFileNameForFileStorage = Path.GetRandomFileName();
                var path = Path.Combine(env.ContentRootPath,
                        env.EnvironmentName, "unsafe_uploads",
                        trustedFileNameForFileStorage);

                await using FileStream fs = new(path, FileMode.Create);
                await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
            }
            catch (Exception ex)
            {
                Logger.LogError("File: {Filename} Error: {Error}",
                    file.Name, ex.Message);
            }
        }

        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<WriteBoard> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
namespace __Blazor.WriteJsonFromInput.Pages.WriteBoard
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
