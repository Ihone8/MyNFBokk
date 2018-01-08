<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebNFBook.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
            width: 583px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center; height:373PX;">
        <p class="auto-style2"><strong>&nbsp;&nbsp;&nbsp;&nbsp; 注册用户登入</strong></p>
        <div style="text-align:center; margin-left:70px; width: 656px;">
            <p>账号(<u>N</u>)：<asp:TextBox ID="txtUserName" runat="server" Width="180" MaxLength="16"></asp:TextBox>&nbsp; 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="请输入账号!" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp;<a href="CustomRegist.aspx" tabindex="5">注册账号</a>
                </p>
            <p>密码 (<u>P</u>)：<asp:TextBox ID="txtPassword" runat="server" Width="180" TextMode="Password" MaxLength="16"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="请输入密码!" ForeColor="Red">*</asp:RequiredFieldValidator>
            &nbsp; <a href="FindPassword.aspx">找回密码</a>
                </p>
            <p style="width: 632px"><asp:Button ID="btnLogin" runat="server" Text="登入"  Width="180px" Height="24px" OnClick="btnLogin_Click"/>
                </p>
            <p style="text-align:center;width: 618px;">
                <asp:Label ID="lblMes" runat="server" Text=""></asp:Label>
            </p>         
        </div> 
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="发现以下错误！" ShowMessageBox="True" ShowSummary="False" />
    </div>
    </asp:Content>
