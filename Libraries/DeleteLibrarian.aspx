<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteLibrarian.aspx.cs" Inherits="Libraries.DeleteLibrarian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
       Enter the ID of the librarian, you want to delete:   </h3>
    <p>
          <asp:TextBox ID="TextBoxDelete" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>