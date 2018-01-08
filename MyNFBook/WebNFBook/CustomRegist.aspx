<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="CustomRegist.aspx.cs" Inherits="WebNFBook.CustomRegist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center; margin-top:0px; height:373PX;" >
       <p class="auto-style2" style="text-align:center; width: 838px;">用户注册</p>
        <div style="text-align:right; width: 537px; float:left; margin:0;padding:0px;">           
            <p>账&nbsp; 号：<asp:TextBox ID="txtUserName" runat="server" Width="200" MaxLength="16"></asp:TextBox>
            </p>
            <p>密&nbsp; 码：<asp:TextBox ID="txtPassword" runat="server"  Width="200" TextMode="Password" MaxLength="16"></asp:TextBox>
            </p>
            <p >重复密码：<asp:TextBox ID="txtPassword2" runat="server"  Width="200px" TextMode="Password" MaxLength="16"></asp:TextBox>

            </p>
            <p >电子邮箱：<asp:TextBox ID="txtEmail" runat="server"  Width="200px"></asp:TextBox>
            </p>
        </div>
        <div style="float:right; width:172px; margin-right:50px; height: 138px;">
            <p  style="margin-top:18px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="请输入账号！">*</asp:RequiredFieldValidator>
            </p>
            <p style="margin-top:18px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="请输入密码！">*</asp:RequiredFieldValidator>
            </p>
            <p  style="margin-top:18px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword2" ErrorMessage="请输入重复密码！">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" ErrorMessage="输入密码不一致！">*</asp:CompareValidator>
            </p>
            <p  style="margin-top:18px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="请填写您的邮箱！">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="邮箱格式不正确！" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </p>
        </div>
        <div style="text-align:right; width: 532px;">
        <p>
            <asp:Button ID="btnRegist" runat="server" Text="注册"  Width="199px" OnClick="btnRegist_Click"/></p>           
        </div>
        <div style="width:791px; ">

        </div>
       <p><asp:Label ID="lblMes" runat="server" ForeColor="Red"></asp:Label></p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="发现以下错误！" ShowMessageBox="True" ShowSummary="False" />
        <p>
        </p>
    </div>
</asp:Content>
