<%@ Page Title="" Language="C#" MasterPageFile="~/Custormer/CustormerMaster.Master" AutoEventWireup="true" CodeBehind="SafetyInfo.aspx.cs" Inherits="WebNFBook.Custormer.SafetyInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <p class="auto-style2">密码保护</p>
        <div style="text-align:right; width: 542px;">     
        <p>密保问题：
              <asp:DropDownList ID="dropQuestion" Width="200px" runat="server" Height="20">
                    <asp:ListItem>您的生日是什么？</asp:ListItem>
                    <asp:ListItem>您最喜欢的电影明星是谁？</asp:ListItem>
                    <asp:ListItem>您的高中班主任是谁？</asp:ListItem>
                    <asp:ListItem>您最喜欢的老师是谁？</asp:ListItem>
                </asp:DropDownList>
        </p>
        <p>答案：<asp:TextBox ID="txtAnswer" runat="server" Width="200"></asp:TextBox></p>
        <p>确认答案：<asp:TextBox ID="txtAnswer2" runat="server" Width="200"></asp:TextBox></p>
            <p>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="答案输入不一致！" ControlToCompare="txtAnswer" ControlToValidate="txtAnswer2"></asp:CompareValidator>
            </p>
</div>
        <p style="margin-left: 160px; width: 548px;">
            <asp:Button ID="butSave" runat="server" Text="保存"  Width="200" OnClick="butSave_Click"/></p>
        <p>
            <asp:Label ID="lblMes" runat="server" ForeColor="Red"></asp:Label></p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="发现以下错误！" ShowMessageBox="True" ShowSummary="False" />
        <p>
        </p>
    </div>
</asp:Content>
