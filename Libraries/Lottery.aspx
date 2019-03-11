<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lottery.aspx.cs" Inherits="Libraries.Lottery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        The winner of the lottery is:</h2>
    <h2>
        <asp:TextBox ID="TextBoxWinner" runat="server" Width="640px"></asp:TextBox>
    </h2>

</asp:Content>
