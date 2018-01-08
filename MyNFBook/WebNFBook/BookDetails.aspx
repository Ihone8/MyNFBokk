<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="WebNFBook.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%; text-align:center;">
            <asp:Image ID="imgCover" runat="server"  Height="180px" Width="145px" />   
        <div style="text-align:left;">
        <p>书名：<asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></p>  
        <p>作者：<asp:Label ID="lblAuthor" runat="server" Text=""></asp:Label>
            </p>
        <p>价格：<asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
            </p>
        <p>类别：<asp:Label ID="lblCategory" runat="server" Text=""></asp:Label>
            </p>
        <p>出版社：<asp:Label ID="lblPublisherName" runat="server" Text=""></asp:Label></p>
        <p>出版日期：<asp:Label ID="lblPublisherDate" runat="server" Text=""></asp:Label></p>
        <p>简介：<asp:Label ID="lblDesc" runat="server" Text=""></asp:Label></p>
        </div>
        
    </div>
    
</asp:Content>
