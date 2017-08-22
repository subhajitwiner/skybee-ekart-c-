<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    signup
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet/signup.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <aside>
            <section>
                <img src="logo/register.jpg" alt="logosign"/>
            </section>
            
        <section>
            <input id="fname" type="text" runat="server" placeholder="Enter first name" />
            <input id="lname" type="text" runat="server" placeholder="Enter Last name" /><br />
            <input id="email" type="email" runat="server" placeholder="Enter Email" />
            <input id="dob" type="date" runat="server" placeholder="Date of birth=year-month-date" /><br />
            <input id="phone" type="text" runat="server" placeholder="Enter phone no" />
            <input id="pan_no" type="text" runat="server" placeholder="Enter pan no" /><br />
            <textarea id="address" cols="20" rows="2" runat="server" placeholder="Enter address"></textarea><br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <input id="password1" type="password" runat="server" placeholder="type your password" />
            <input id="password2" type="password" runat="server" placeholder="retype your password" /><br />
            <input type="button" runat="server" value="submit" onserverclick="useuser_signup" />
        </section>
    </aside>
    </asp:Content>


