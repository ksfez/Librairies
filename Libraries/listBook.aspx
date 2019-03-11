<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listBook.aspx.cs" Inherits="Libraries.listBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <h2>
         Welcome
    
         &nbsp;<asp:TextBox ID="TextBoxFirstName" style="margin-bottom: 0px" runat="server" Width="144px" ></asp:TextBox>
         <asp:TextBox ID="TextBoxLastName" runat="server" style="margin-bottom: 0px" Width="144px" ></asp:TextBox>
     </h2>

    <h2>

        Lended books:


    </h2>
    
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p>&nbsp;</p>
    <h2>
        Favorite author:
    </h2>
    <br />
        <asp:TextBox ID="TextBoxAuthor"  runat="server" Height="16px" style="margin-left: 0px" OnTextChanged="TextBoxAuthor_TextChanged" Width="144px"></asp:TextBox>
    <h2>
        Penalty:
    </h2>
    <p>
       <asp:TextBox ID="TextBoxPenalty" runat="server" Height="16px" style="margin-left: 0px" OnTextChanged="TextBoxPenalty_TextChanged" Width="144px"></asp:TextBox>
    </p>
</asp:Content>
