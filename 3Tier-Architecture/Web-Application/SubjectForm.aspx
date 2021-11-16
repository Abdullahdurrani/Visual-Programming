<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubjectForm.aspx.cs" Inherits="_3Tier_Lab_25_Oct.SubjectForm" %>

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
                    <asp:Label ID="lblTitle" runat="server" Text="Enter Title"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblCreditHours" runat="server" Text="Enter Credit Hours"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCreditHours" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblDepartment" runat="server" Text="Enter Department"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblTeacher" runat="server" Text="Enter Teacher Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTeacher" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>

                <td>
                    <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
                    &nbsp;
                    <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="btnDelete_Click" />
                    &nbsp;
                    <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" />
                    &nbsp;
                    <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="3">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
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
