#pragma checksum "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054f73c6a2da4ea97064e3082c68cdf269c37721"
// <auto-generated/>
#pragma warning disable 1591
namespace EventsPWA.Shared
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
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
     headerline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "<label>User Name</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "name", "username");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
                                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user = __value, user));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "<label>Password</label>\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", 
#nullable restore
#line 9 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
                  myfunc()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "name", "password");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
                                                    pass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pass = __value, pass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "submit");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
                                OnLoginCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "LOGIN");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Dipen\OneDrive\Desktop\asp .net\as7\EventsPWA\Shared\LoginComponent.razor"
      
    [Parameter]
    public bool PasswordVisible{get;set;}
    public string headerline ;
    public string user;
    public string pass;
    public void OnLoginCallback(){
        if(user == "test"){
            if(pass == "test"){
                PasswordVisible = false;
                headerline = "Login Success";
            }
        }else{
            
            headerline ="Login credential is false.";
        }
        
        
    }
    public string myfunc(){
        if(PasswordVisible){
            return "text";
        }else{
            return "password";
        }
    }
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
