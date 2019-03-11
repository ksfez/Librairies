<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Libraries.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Search book:
    </p>
<p>
        <asp:TextBox ID="TextBoxSearch" runat="server" OnTextChanged="TextBoxSearch_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonSearch" runat="server" OnClick="Search_Click" Text="Search" Height="32px" />
    </p>
            <asp:Label ID="Available"  runat="server" Text="Number of Available:" Font-Bold="True" Font-Italic="True" Font-Strikeout="False" Font-Underline="False" Font-Names="Arial"></asp:Label>

    <p>
        <asp:TextBox ID="TextBoxAvailable" runat="server"></asp:TextBox>
    </p>
<p>
         <asp:Label ID="Libraries"  runat="server" Text="You can find this book in the Libraries:" Font-Bold="True" Font-Italic="True" Font-Strikeout="False" Font-Underline="False" Font-Names="Arial"></asp:Label>
</p>
    <p>
        <asp:TextBox ID="TextBoxLibraries" runat="server" Width="797px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
</asp:Content>