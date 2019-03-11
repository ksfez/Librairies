<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Libraries.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server" >
    
        
            <h2>
                SIGN IN
            </h2>
            <p>
                Enter your ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="IDin" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="ButtonSignIn" runat="server" OnClick="SignIn_Click" style="margin-left: 349px" Text="Sign in" Width="124px" />
            </p>
            <h2>
                SIGN UP</h2>
            <p>
                Enter your ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="IDup" runat="server"></asp:TextBox>
            </p>
            <p>
                Enter your first name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
&nbsp;</p>
            <p>
                Enter your last name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            </p>
            <p>
                Enter your age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="textBoxAge" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="ButtonSignUp" runat="server" OnClick="SignUp_Click" style="margin-left: 349px" Text="Sign up" Width="124px" />
            </p>
            <p>
                &nbsp;</p>
   
</asp:Content>
