#pragma checksum "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "676e93e00e63ce619a17a40e3a25586c1050a17b"
// <auto-generated/>
#pragma warning disable 1591
namespace DKHC_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using DKHC_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/_Imports.razor"
using DKHC_Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>User-Login</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Please login with e-mail-adress and password:</p>\n<br>\n\n");
            __builder.AddMarkupContent(2, @"<div class=""login-box"">
    <label for=""inputEmail"">email-adress</label>
    <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""email-adress"">
    <br>
    <label for=""inputPassword"">password</label>
    <input type=""password"" class=""form-control"" id=""inputPassword"" placeholder=""password"">
    <br>
    <button type=""submit"" class=""btn btn-primary"">Confirm</button>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
