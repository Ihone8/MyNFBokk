<%@ Page Title="" Language="C#" MasterPageFile="~/Custormer/CustormerMaster.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebNFBook.Custormer.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <p class="auto-style2" >&nbsp;&nbsp;&nbsp;&nbsp;修改密码</p>
        <div style="text-align:right; width: 566px;">  
        <p>旧密码：<asp:TextBox ID="txtOldPwd" runat="server" Width="200" TextMode="Password"></asp:TextBox></p>
        <p>新密码：<asp:TextBox ID="txtNewPwd" runat="server" Width="200" TextMode="Password"></asp:TextBox></p>
        <p>重复新密码：<asp:TextBox ID="txtNewPwd2" runat="server" Width="200" TextMode="Password"></asp:TextBox></p>
            <p style="width: 533px"><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="俩次密码输入 不一致！" ControlToCompare="txtNewPwd" ControlToValidate="txtNewPwd2" ForeColor="Red"></asp:CompareValidator></p>
                </div>
        <p style="margin-left: 240px; width: 436px;">
            &nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" Text="保存"  Width="200" OnClick="btnSave_Click"/>
            <br />
            <asp:Label ID="lblMes" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="发现以下错误！" ShowMessageBox="True" ShowSummary="False" />
    </div>
</asp:Content>
