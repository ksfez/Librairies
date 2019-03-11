<%@ Page Title="Tables" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="Libraries.Tables" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
            

            <h2>Readers</h2>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
  
            <h2>Lending</h2>
            <p>
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </p>
            
            <h2>CopyBooks</h2>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
           
            <h2>Books</h2>
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
           <h2> BelongsTo</h2>
           <asp:GridView ID="GridView5" runat="server">
            </asp:GridView>
            <h2>Libraries</h2>
        <asp:GridView ID="GridView6" runat="server">
            </asp:GridView>
            <h2>Librarian</h2>
        <asp:GridView ID="GridView7" runat="server">
            </asp:GridView>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
    .auto-style2 {
        width: 600px;
        height: 700px;
    }
</style>
</asp:Content>

