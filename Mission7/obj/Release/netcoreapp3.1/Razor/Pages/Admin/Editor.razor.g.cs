#pragma checksum "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9eebfbedb2051781bbd45721a4e197619195153"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<iBookRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220,53,69);\r\n        font-weight: 500\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 12 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                 b

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                   SaveBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 17 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
     if (b.BookId != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label>Book ID</label>");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 20 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                                               b.BookId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 22 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Title:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 25 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Title = __value, b.Title))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label>Author:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 31 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Author

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Author = __value, b.Author))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label>Publisher:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 37 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Publisher

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Publisher

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Publisher = __value, b.Publisher))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Publisher));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.AddMarkupContent(70, "<label>ISBN:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 43 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Isbn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Isbn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Isbn = __value, b.Isbn))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Isbn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.AddMarkupContent(84, "<label>Classification:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 48 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Classification

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Classification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Classification = __value, b.Classification))));
                __builder2.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Classification));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group");
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.AddMarkupContent(98, "<label>Category:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_5(__builder2, 99, 100, 
#nullable restore
#line 53 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                      b.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Category = __value, b.Category))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group");
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.AddMarkupContent(112, "<label>Page Count:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_6(__builder2, 113, 114, 
#nullable restore
#line 58 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.PageCount

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(115, "\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateInputNumber_7(__builder2, 116, 117, "form-control", 118, 
#nullable restore
#line 59 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                        b.PageCount

#line default
#line hidden
#nullable disable
                , 119, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.PageCount = __value, b.PageCount)), 120, () => b.PageCount);
                __builder2.AddMarkupContent(121, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group");
                __builder2.AddMarkupContent(125, "\r\n        ");
                __builder2.AddMarkupContent(126, "<label>Price:</label>\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateValidationMessage_8(__builder2, 127, 128, 
#nullable restore
#line 63 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                  () => b.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(129, "\r\n        ");
                __Blazor.Mission7.Pages.Admin.Editor.TypeInference.CreateInputNumber_9(__builder2, 130, 131, "form-control", 132, 
#nullable restore
#line 64 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                                        b.Price

#line default
#line hidden
#nullable disable
                , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Price = __value, b.Price)), 134, () => b.Price);
                __builder2.AddMarkupContent(135, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(137, "button");
                __builder2.AddAttribute(138, "type", "submit");
                __builder2.AddAttribute(139, "class", "btn" + " btn-" + (
#nullable restore
#line 68 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(140, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(142);
                __builder2.AddAttribute(143, "class", "btn btn-secondary");
                __builder2.AddAttribute(144, "href", "/admin");
                __builder2.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(146, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Editor.razor"
       


    [Parameter]
    public long Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Book b { get; set; } = new Book();

    public iBookRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            b = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void SaveBook()
    {
        if (Id == 0)
        {
            repo.CreateBook(b);
        }
        else
        {
            repo.SaveBook(b);
        }
        NavManager.NavigateTo("/admin", true);

    }
    [Inject]
    public NavigationManager NavManager { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Mission7.Pages.Admin.Editor
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591