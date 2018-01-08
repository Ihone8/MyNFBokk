<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="FindPassword.aspx.cs" Inherits="WebNFBook.FindPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center; width:355px; height:373PX; margin-left:230px;">
    <p style=" font-size: xx-large; text-align:center; width: 301px;">找回密码</p>
        <div style="text-align:center; width:330PX; height:200PX;">
        <p style="text-align:left;">账号  (<u>U</u>)：<asp:TextBox runat="server" ID="txtUserID"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserID" ErrorMessage="请输入您的账号！">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button  runat="server" ID="btnFind" Text="查找" Width="56px" OnClick="btnFind_Click" /></p>
            <p style="text-align:left;">
                <asp:Label ID="lblMes" runat="server"></asp:Label>
            </p>
        <asp:Panel runat="server" ID="panpl">
            <p style="text-align:left;">密保问题：<asp:Label runat="server" ID="lblUserQuestion"></asp:Label></p>
            <p style="text-align:left;" >答案  (<u>A</u>)：<asp:TextBox runat="server" ID="txtAnswer"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAnswer" ErrorMessage="请填写密保问题答案">*</asp:RequiredFieldValidator>
            </p>
                <p style="margin-left:5px; width: 316px;" >
                    <asp:Button ID="btnFindPwd" runat="server" Text="找回" Width="171px" OnClick="btnFindPwd_Click" />
            </p>
            </asp:Panel>
            <p>
                <asp:Label ID="lblPwdMes" runat="server" Text=""></asp:Label></p>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" HeaderText="发现以下错误" />
        </div>
    </div>
</asp:Content>
