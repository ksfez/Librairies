<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMyProfile.aspx.cs" Inherits="Libraries.UpdateMyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


    <h2>
                Update my profile:</h2>
            <p>
                Enter your&nbsp; ID:&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="TextBoxID" style="margin-bottom: 0px" Width="144px" runat="server"></asp:TextBox>
    </p>
   
            <p>
                Enter your new first name:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="firstName"  style="margin-bottom: 0px" runat="server" Width="144px"></asp:TextBox>
                </p>
   
            <p>
                Enter your new last name:&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;<asp:TextBox ID="lastName" runat="server"  style="margin-bottom: 0px" Width="144px"></asp:TextBox>
                </p>
   
            <p>
                Enter your new age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="textBoxAge"  style="margin-bottom: 0px" runat="server" Width="144px"></asp:TextBox>
                </p>
    
            <p>
                <asp:Button ID="ButtonUpdate" runat="server" OnClick="Update_Click" style="margin-left: 349px" Text="Update" Width="124px" />
            </p>
           
   
</asp:Content>

