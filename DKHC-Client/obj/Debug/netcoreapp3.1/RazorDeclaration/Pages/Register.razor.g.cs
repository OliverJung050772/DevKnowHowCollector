#pragma checksum "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cbc8808005c34edee930b31d54e88d4814dcf50"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DKHC_Client.Pages
{
    #line hidden
    using System;
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
#nullable restore
#line 2 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
using DKHC_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
using DKHC_Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
       

    private string eMail = string.Empty;
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private string passWord = string.Empty;
    private string repeatedPassWord = string.Empty;

    private bool isValid = false;
    private string errorMessage = string.Empty;

    private async void RegisterButtonClicked()
    {
        if (FormIsValid())
        {
            Console.WriteLine("Login successful!");
            var allMembers = await ApiService.GetAllMembers();
            IList<Member> memberList = allMembers.ToList();
            foreach(Member member in memberList)
            {
                Console.WriteLine(member.FirstName + ", " + member.LastName + " " + member.Email);
            }
        }
    }

    private bool FormIsValid()
    {
        if (eMail.Count() < 4 || !eMail.Contains("@"))
        {
            errorMessage="e-mail address to short or false!";
            isValid = false;
            return false;
        }
        else if (firstName.Count() < 2 || lastName.Count() < 2)
        {
            errorMessage="first-/last- name to short!";
            isValid = false;
            return false; 
        }      
        else if (passWord != repeatedPassWord || passWord.Count() <5 || repeatedPassWord.Count() <5)
        {
            errorMessage ="password(s) different or to short!";
            isValid = false;
            return false;
        }            
        else 
        {
            isValid = true;
            return true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DevCollApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
