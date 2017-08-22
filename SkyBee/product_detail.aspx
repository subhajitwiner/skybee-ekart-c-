<%@ Page Title="" Language="C#" MasterPageFile="~/Structure3.master" AutoEventWireup="true" CodeFile="product_detail.aspx.cs" Inherits="product_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet/product_detail.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            left: 129px;
            top: 39px;
            width: 251px;
        }
        .auto-style2 {
            left: 10px;
            top: 37px;
            width: 101px;
        }
        .auto-style4 {
            left: 13px;
            top: 90px;
            width: 101px;
        }
        .auto-style6 {
            left: 131px;
            top: 94px;
            width: 251px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <section  >
        <img  src="<% Response.Write(product_img); %>" style="top: 11px; left: 28px; height: 180px; width: 225px" />
        <br />
       <br />
    
        <br />
    
        <input type="button" runat="server" value="buy" onserverclick="bye_ServerClick" style="top: 246px; left: 31px; width: 223px; height: 29px" /><br />
    
       <asp:Label CssClass="fidback" ID="fidback" runat="server" Text=""></asp:Label>
        <label ><%Response.Write("Item left "+product_quantity+" pices"); %></label>
        <div class="information" >

            
            <label class="auto-style2">Model Name</label>
            <label class="auto-style1"><% Response.Write(product_name); %>&nbsp;&nbsp;&nbsp; </label>

            

            &nbsp;<label class="auto-style4">Price</label><label class="auto-style6"><% Response.Write(product_price); %>&nbsp;&nbsp;&nbsp; </label>

            

        </div>
    </section>
    
</asp:Content>

