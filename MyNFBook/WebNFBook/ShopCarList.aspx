<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="ShopCarList.aspx.cs" Inherits="WebNFBook.ShopCarList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="dgdShopCar" runat="server">
        <ItemTemplate>
            <div style="display: inline-block;">
                <asp:Image ID="imgCover" runat="server" Width="110" ImageUrl="~/Image/BookCovers/7030177169.jpg" />
            </div>
            <div style="display: inline-block;">
                <p>书名：<%#Eval("Title") %></p>
                <p>价格：<%#Eval("Price") %></p>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
           <div style="display: inline-block;">
                <asp:Image ID="imgCover" runat="server" Width="110" ImageUrl="~/Image/BookCovers/7030177169.jpg" />
            </div>
            <div style="display: inline-block;">
                <p>书名：<%#Eval("Title") %></p>
                <p>价格：<%#Eval("Price") %></p>
            </div>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
        <HeaderTemplate>

            <p style="text-align: center;">购物车</p>
        </HeaderTemplate>
    </asp:Repeater>
</asp:Content>
