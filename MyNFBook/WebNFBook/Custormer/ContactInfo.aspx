<%@ Page Title="" Language="C#" MasterPageFile="~/Custormer/CustormerMaster.Master" AutoEventWireup="true" CodeBehind="ContactInfo.aspx.cs" Inherits="WebNFBook.Custormer.ContactInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <p class="auto-style2">用户联系方式</p>
        <p>联系电话：<asp:TextBox ID="txtPhone" runat="server" Width="200" MaxLength="11"></asp:TextBox></p>
        <p>QQ/微信：<asp:TextBox ID="txtQQMSN" runat="server" Width="200"></asp:TextBox></p>
        <p>电子邮箱：<asp:TextBox ID="txtEmail" runat="server" Width="200"></asp:TextBox></p>
        <p style="margin-left: 80px">
            <asp:Button ID="Button1" runat="server" Text="保存"  Width="200" OnClick="Button1_Click"/></p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblMes" runat="server" ForeColor="#FF3300"></asp:Label></p>
    </div>
</asp:Content>
