<%@ Page Title="" Language="C#" MasterPageFile="~/structure2.master" AutoEventWireup="true" CodeFile="productlist.aspx.cs" Inherits="productlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    product list
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet/productlist.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <form action="product_detail.aspx" method="get">
        <%
            int i;
            for( i = 0; i < total_product; i++)
            {
                int qty = int.Parse(total_quantity[i]);

   %>
    
    <table>
        <tr>
            <td><img src="<% Response.Write(product_picture[i]); %>" /></td>
        </tr>
        <tr>
            <td><input type="submit" name="but1" value="<%Response.Write(product_name[i]); %>" /></td>
        </tr>
    </table>
   <%
       }
   %>
    </form>
   
</asp:Content>

