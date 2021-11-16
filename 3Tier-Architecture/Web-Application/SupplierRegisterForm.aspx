<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierRegisterForm.aspx.cs" Inherits="_3Tier_Lab_25_Oct.SupplierRegisterForm" %>

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
                    <asp:Label ID="lblFirstName" runat="server" Text="Enter First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblLastName" runat="server" Text="Enter Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Enter Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
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
                <td>
                    <asp:Label ID="lblAddress" runat="server" Text="Enter Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblPhoneNumber" runat="server" Text="Enter Phone Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblAge" runat="server" Text="Enter Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblBalance" runat="server" Text="Enter Balance"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server" Text="Enter City"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblOrders" runat="server" Text="Enter Orders"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtOrders" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>

                <td>
                    <asp:Button ID="btnRegister" Text="Sign Up" runat="server" OnClick="btnRegister_Click" />
                    &nbsp;
                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="3">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>


            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="gridViewUser" runat="server"></asp:GridView>
                </td>
            </tr>

            <tr>
                <td></td>
            </tr>
        </table> 
    </form>
</body>
</html>
