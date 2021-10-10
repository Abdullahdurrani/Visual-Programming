<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebForms.Product" %>

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
        .auto-style6 {
            width: 91px;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            width: 100px;
        }
        .auto-style7 {
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" Text="Product Form"></asp:Label>
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
                        <asp:Label ID="Label1" runat="server" Text="Product Id"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="Product Title"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Text="Sub Category"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtSubCategory" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label7" runat="server" Text="Weight"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label8" runat="server" Text="Color"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="Label10" runat="server" Text="Items Available"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtItems" runat="server"></asp:TextBox>
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
