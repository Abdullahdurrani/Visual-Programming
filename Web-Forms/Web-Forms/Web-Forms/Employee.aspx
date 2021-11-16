<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebForms.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            width: 100px;
        }
        .auto-style5 {
            width: 98px;
        }
        .auto-style6 {
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" Text="Employee Form"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
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
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" Text="Cellphone"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label5" runat="server" Text="Education"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEducation" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label6" runat="server" Text="Salary"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label7" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="Label8" runat="server" Text="Position"></asp:Label>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
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
                    <td class="auto-style5">&nbsp;</td>
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
