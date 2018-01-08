<%@ Page Title="" Language="C#" MasterPageFile="~/Custormer/CustormerMaster.Master" AutoEventWireup="true" CodeBehind="BasicInfo.aspx.cs" Inherits="WebNFBook.Custormer.BasicInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
        margin-left: 240px;
        width: 302px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:500px;">
    <div style="text-align:center; height: 170px; width: 500px;">
        <p class="auto-style2">用户个人基本信息</p>
        <div style="text-align:right; width: 302px; margin-left: 200px; height: 101px;">       
        <p>姓&nbsp;名:<asp:TextBox ID="txtName" runat="server" Width="200"></asp:TextBox></p>
            <p>性&nbsp;别:           
           <asp:DropDownList ID="dropGender" runat="server" Width="200">
               <asp:ListItem Text="男" Value="1"></asp:ListItem>
               <asp:ListItem Text="女" Value="2"></asp:ListItem>
           </asp:DropDownList>
        </p>
        <p>出生日期:<asp:TextBox ID="txtBirthday" runat="server" Width="200" ></asp:TextBox></p>
            </div>
</div>
    <div style="text-align:center;">
        <p style="margin-left: 80px; width: 614px;"><asp:Button ID="btnSaveUserInfor" runat="server" Text="保存" Width="169px" OnClick="btnSaveUserInfor_Click" /></p>
        <p style="margin-left: 280px">
            <asp:Label ID="lblMes" runat="server" ForeColor="Red"></asp:Label></p>
    </div>   
        </div>
</asp:Content>
