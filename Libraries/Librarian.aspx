<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Librarian.aspx.cs" Inherits="Libraries.Librarian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        THIS PAGE IS ONLY FOR LIBRARIAN!!</h2>
    <p>
        <asp:Button ID="ButtonAdd" runat="server" Text="To add a librarian" OnClick="ButtonAdd_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelete" runat="server" Text="To delete a librarian" OnClick="ButtonDelete_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonUpdate" runat="server" Text="To update a librarian" OnClick="ButtonUpdate_Click" />
    </p>
    <h2>
    </h2>
</asp:Content>
