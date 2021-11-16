<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebForms.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 98px;
        }
        .auto-style7 {
            width: 130px;
        }
        .auto-style6 {
            width: 91px;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            width: 100px;
        }
        .auto-style8 {
            width: 98px;
            height: 29px;
        }
        .auto-style9 {
            width: 130px;
            height: 29px;
        }
        .auto-style10 {
            width: 91px;
            height: 29px;
        }
        .auto-style11 {
            width: 173px;
            height: 29px;
        }
        .auto-style12 {
            width: 100px;
            height: 29px;
        }
        .auto-style13 {
            height: 29px;
        }
        .auto-style18 {
            width: 100px;
            height: 23px;
        }
        .auto-style19 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" Text="Customer Form"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="lblName" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="lblName0" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style18"></td>
                    <td class="auto-style19"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">
                        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label6" runat="server" Text="Balance"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label7" runat="server" Text="Orders"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtOrders" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td colspan="3">
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td colspan="3">
                        <asp:Label ID="lblInfo" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
