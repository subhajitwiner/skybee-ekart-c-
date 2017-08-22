<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Adminlogin.aspx.cs" Inherits="Adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 650px;
        }
        .auto-style2 {
            width: 630px;
            height: 49px;
            position: absolute;
            top: 15px;
            left: 297px;
            z-index: 1;
            text-align: center;
        }
        .auto-style3 {
            width: 738px;
            height: 432px;
            position: absolute;
            top: 71px;
            left: 247px;
            z-index: 1;
        }
        .auto-style4 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <div class="auto-style2">
            <strong>Admin Login</strong></div>
        <div class="auto-style3">
            <table class="auto-style4">
                <tr>
                    <td>Enter Admin Email</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Admin Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
