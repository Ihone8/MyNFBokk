<%@ Page Title="" Language="C#" MasterPageFile="~/NFBookMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebNFBook._default " EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Repeater ID="dgdShowBook" runat="server" OnItemCommand="dgdShowBook_ItemCommand">           
        <ItemTemplate>
            <table style="padding: 5px; width: 100%;background-color:#94AAD6;">
                <tr>
                    <td rowspan="5" style="width: 110px;">
                    <a href='<%# "MyHandler.ashx?ISBN="+Eval("ISBN") %>' target="_blank">
                        <asp:Image ID="imgCover" Width="100" Height="120" ImageUrl='<%# "~/Image/BookCovers/"+Eval("ISBN")+".jpg" %>'
                            runat="server" /></a>
                    </td>
                    <td style="text-align: left;">
                        书名：<a href='<%# "BookDetails.aspx?ID="+Eval("ID") %>'><%# Eval("Title") %></a></td>
                </tr>
                <tr>
                    <td>
                        出版社：<%#Eval("PublisherName") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        作者：<%# Eval("Author") %></td>
                </tr>
               <%-- <tr>
                    <td style="text-align: left;">
                        出版社：<%# Eval("PublisherName") %></td>
                </tr>--%>
                <tr>
                    <td style="text-align: left;">
                        价格：<%# Eval("Price","{0:C}") %></td>
                </tr>
                <tr>
                    <td style="text-align: right;">
                        <asp:Button ID="btnBuy" runat="server" CommandName='<%# Eval("ID") %>' Text="购买" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <table style="padding: 5px; width: 100%;background-color:#FCE0A6;">
                <tr>
                    <td rowspan="5" style="width: 110px;">
                    <a href='<%# "MyHandler.ashx?ISBN="+Eval("ISBN") %> target="_blank"'>
                        <asp:Image ID="imgCover" Width="100" Height="120" ImageUrl='<%# "~/Image/BookCovers/"+Eval("ISBN")+".jpg" %>'
                            runat="server" /></a>
                    </td>
                    <td style="text-align: left;">
                        书名：<a href='<%# "BookDetails.aspx?ID="+Eval("ID") %>'><%# Eval("Title") %></a></td>
                </tr>
                <tr>
                    <td>
                        出版社：<%#Eval("PublisherName")%></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        作者：<%# Eval("Author")%></td>
                </tr>
                <%--<tr>
                    <td style="text-align: left;">
                        出版社：<%# Eval("PublisherName") %></td>
                </tr>--%>
                <tr>
                    <td style="text-align: left;">
                        价格：<%# Eval("Price","{0:C}") %></td>
                </tr>
                <tr>
                    <td style="text-align: right;">
                        <asp:Button ID="btnBuy"  CommandName='<%# Eval("ID") %>' runat="server" Text="购买" />
                    </td>
                </tr>
            </table>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
    </asp:Repeater>
</asp:Content>
