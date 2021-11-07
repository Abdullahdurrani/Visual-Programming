<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="_3Tier_Lab_25_Oct.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>

            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="Enter Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Enter Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>

                <td>
                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
                    &nbsp;
                    <asp:Button ID="btnRegisterEmployee" Text="Register as Employee" runat="server" OnClick="btnRegisterEmployee_Click" />
                    &nbsp;
                    <asp:Button ID="btnRegisterCustomer" Text="Register as Customer" runat="server" OnClick="btnRegisterCustomer_Click" />
                    &nbsp;
                    <asp:Button ID="btnRegisterSupplier" Text="Register as Supplier" runat="server" OnClick="btnRegisterSupplier_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="3">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
