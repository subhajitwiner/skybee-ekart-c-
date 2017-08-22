<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 345px;
            width: 422px;
        }
        .auto-style2 {
            width: 409px;
            height: 47px;
            position: absolute;
            top: 45px;
            left: 7px;
            z-index: 1;
            text-align: center;
            font-size: xx-large;
            color: #3333FF;
        }
        .auto-style3 {
            width: 395px;
            height: 244px;
            position: absolute;
            top: 110px;
            left: -116px;
            z-index: 1;
            margin-left: 139px;
        }
        .auto-style4 {
            width: 98%;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            height: 42px;
        }
        .auto-style7 {
            position: absolute;
            left: 443px;
            top: 23px;
            width: 339px;
            height: 382px;
        }
        .auto-style8 {
            height: 281px;
        }
       
    </style>
</head>
<body style="height: 408px; width: 783px;">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <div class="auto-style2">
            <strong>Product Insertion</strong></div>
        <div class="auto-style3">
            <table class="auto-style4">
                <tr>
                    <td>Enter Brand Id</td>
                    <td>
                        <asp:TextBox ID="brandID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Product Id</td>
                    <td>
                        <asp:TextBox ID="productID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Product Name</td>
                    <td>
                        <asp:TextBox ID="productNAME" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Upload Product Image</td>
                    <td class="auto-style5">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="194px" />
                    </td>
                </tr>
                <tr>
                    <td>Enter Quentaty of Product</td>
                    <td>
                        <asp:TextBox ID="productQUANTITY" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Enter Price Per Quantity</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="productRATE" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    <div class="auto-style7">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="brandname" DataValueField="brandid" >
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server"  Text="Button" OnClick="Button2_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:skybeeConnectionString %>" ProviderName="<%$ ConnectionStrings:skybeeConnectionString.ProviderName %>" SelectCommand="SELECT brandname,brandid FROM brand"></asp:SqlDataSource>
        <br />
        <div class="auto-style8">
            <br />
            
            <asp:Label ID="Label2" runat="server" Width="336px"></asp:Label>
        </div>
    </div>
    </form>
    </body>
</html>
