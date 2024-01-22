#pragma checksum "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d17c16d0fb58141fb06fba09617f1c2d9783f9e813b4e3f1224df92400d9f8b8"
// <auto-generated/>
#pragma warning disable 1591
namespace TimeTracker.Client.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client;

#line default
#line hidden
#line 8 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client.Shared;

#line default
#line hidden
#line 9 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 10 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
    public partial class Pager<
#line 1 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
T

#line default
#line hidden
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
 if (Model != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "aria-label", "Pager");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "pagination");
            __builder.AddMarkupContent(6, "\n");
#line 8 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
             if (Model.Page == 1)
            {

#line default
#line hidden
            __builder.AddContent(7, "                ");
            __builder.AddMarkupContent(8, "<li class=\"page-item disabled\">\n                    <a class=\"page-link\" href=\"javascript: void(0)\" tabindex=\"-1\">&laquo;</a>\n                </li>\n");
#line 13 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "page-item");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "class", "page-link");
            __builder.AddAttribute(15, "href", "javascript: void(0)");
            __builder.AddAttribute(16, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
                                                                              (async () => await Loader(1))

#line default
#line hidden
            ));
            __builder.AddContent(17, "«");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#line 19 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
            }

#line default
#line hidden
#line 20 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
             for (var i = 1; i <= Model.TotalPages; i++)
            {
                var pageNumber = i;
                var item = Model.Items.FirstOrDefault();


#line default
#line hidden
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "page-item" + " " + (
#line 25 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
                                       pageNumber == Model.Page ? "active" : ""

#line default
#line hidden
            ));
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "page-link");
            __builder.AddAttribute(26, "href", "javascript: void(0)");
            __builder.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
                                                                              (async () => await Loader(pageNumber))

#line default
#line hidden
            ));
#line 26 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
__builder.AddContent(28, i);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#line 28 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
            }

#line default
#line hidden
#line 29 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
             if (Model.Page == Model.TotalPages)
            {

#line default
#line hidden
            __builder.AddContent(31, "                ");
            __builder.AddMarkupContent(32, "<li class=\"page-item disabled\">\n                    <a class=\"page-link\" href=\"javascript: void(0)\" tabindex=\"-1\">&raquo;</a>\n                </li>\n");
#line 34 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "page-item");
            __builder.AddMarkupContent(36, "\n                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "page-link");
            __builder.AddAttribute(39, "href", "javascript: void(0)");
            __builder.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
                                                                              (async () => await Loader(Model.TotalPages))

#line default
#line hidden
            ));
            __builder.AddContent(41, "»");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#line 40 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
            }

#line default
#line hidden
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
#line 43 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 45 "C:\Users\Admin\Downloads\TimeTracker\src\TimeTracker.Client\Shared\Pager.razor"
       
    [Parameter] public PagedList<T> Model { get; set; }
    [Parameter] public Func<int, Task> Loader { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591