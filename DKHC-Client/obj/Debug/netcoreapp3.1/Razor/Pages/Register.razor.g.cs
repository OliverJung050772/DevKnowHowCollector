#pragma checksum "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee94e8cbcdd430eb5e99400cd498dd1664acb22c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Register as new user</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Please register with your e-mail-adress, name and password:</p>\n<br>\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "login-box");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.AddMarkupContent(5, "<label for=\"inputEmail\">email-adress</label>\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "email");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "id", "inputEmail");
            __builder.AddAttribute(10, "placeholder", "email-adress");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 15 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                eMail

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                     (ChangeEventArgs e) => {
            eMail = e.Value.ToString();
            FormIsValid();
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    <br>\n    ");
            __builder.AddMarkupContent(14, "<label for=\"inputFirstName\">first name</label>\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "id", "inputFirstName");
            __builder.AddAttribute(19, "placeholder", "first name");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 24 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                     (ChangeEventArgs e) => {
            firstName = e.Value.ToString();
            FormIsValid();
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    <br>\n    ");
            __builder.AddMarkupContent(23, "<label for=\"inputLastName\">last name</label>\n    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "id", "inputLastName");
            __builder.AddAttribute(28, "placeholder", "last name");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 33 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                lastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                     (ChangeEventArgs e) => {
            lastName = e.Value.ToString();
            FormIsValid();
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    <br>\n    ");
            __builder.AddMarkupContent(32, "<label for=\"inputPassword\">password</label>\n    ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "password");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "id", "inputPassword");
            __builder.AddAttribute(37, "placeholder", "password");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 42 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                passWord

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                     (ChangeEventArgs e) => {
            passWord = e.Value.ToString();
            FormIsValid();
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    <br>\n    ");
            __builder.AddMarkupContent(41, "<label for=\"inputPassword2\">repeat password</label>\n    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "password");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "id", "inputPassword2");
            __builder.AddAttribute(46, "placeholder", "repeat password");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 51 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                repeatedPassWord

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                     (ChangeEventArgs e) => {
            repeatedPassWord = e.Value.ToString();
            FormIsValid();
        }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n    <br>\n");
#nullable restore
#line 58 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
     if (!isValid)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "        ");
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "class", "error-text");
            __builder.AddContent(53, 
#nullable restore
#line 60 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                               errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
#nullable restore
#line 61 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
     if (isValid)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "        ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
                          RegisterButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "class", "btn btn-primary");
            __builder.AddContent(59, "Register Now");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
#nullable restore
#line 65 "/home/oliver/Dokumente/Git-Repos/DevKnowHowCollector/DKHC-Client/Pages/Register.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
            // Testing:
            PrintCurrentMembers();

            Console.WriteLine("New registration requested...");
            Member newMember = new Member();
            newMember.FirstName = firstName;
            newMember.LastName = lastName;
            newMember.Email = eMail;
            newMember.Password = passWord;
            
            var registeredMember = await ApiService.SaveNewMemberAsync(newMember);
            if (registeredMember != null)
            {
                Console.WriteLine("Registered new member " + registeredMember.FirstName 
                    + " " + registeredMember.LastName + " successfully!");
            }
            else
            {
                Console.WriteLine("ERROR: Registration failed!");
            }              
        }
    }

    private async void PrintCurrentMembers()
    {
        Console.WriteLine("Current members:");
        var allMembers = await ApiService.GetAllMembersAsync();
        IList<Member> memberList = allMembers.ToList();
        foreach(Member member in memberList)
        {
            Console.WriteLine(member.MembId + ": " + member.FirstName + ", " + member.LastName 
                + " " + member.Email);
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

    private async Task<bool> emailExistsAsync()
    {
        // TODO: implement email verification
        return false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DevCollApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
