#pragma checksum "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Account\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0042f883539414d1117965dae5ab6e54cb959cf"
// <auto-generated/>
#pragma warning disable 1591
namespace EventsPWA.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using EventsPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\_Imports.razor"
using EventsPWA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world! this is account</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    Login using username \"test\" and password \"test\" for sucessfully login message\r\n</p>\r\n\r\n");
            __builder.OpenComponent<EventsPWA.Shared.LoginComponent>(2);
            __builder.AddAttribute(3, "PasswordVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Account\Index.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591