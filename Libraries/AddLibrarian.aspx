<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddLibrarian.aspx.cs" Inherits="Libraries.AddLibrarian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <h2>
        Add a librarian:</h2>
    <p>
        <br />
        ID:</p>
    <p>
        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
    </p>
    <p>
        First name:
    </p>
    <p>
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
    </p>
    <p>
        Last name:</p>
    <p>
        <asp:TextBox ID="TextBoxLastName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p>
        Salary:</p>
    <p>
        <asp:TextBox ID="TextBoxSalary" runat="server"></asp:TextBox>
    </p>
    <p>
        ID of the library where you will work:</p>
    <p>
        <asp:TextBox ID="TextBoxIDLib" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" />
    </p>
</asp:Content>
