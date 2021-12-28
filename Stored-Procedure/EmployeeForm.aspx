<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="Stored_Procedure.EmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center">Employee Form</h2>

    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Id</td>
            <td>
                <asp:TextBox ID="TBId" runat="server" Height="22px" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Name</td>
            <td>
                <asp:TextBox ID="TBName" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">Employee Email</td>
            <td>
                <asp:TextBox ID="TBEmail" runat="server" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonInsert" runat="server" OnClick="Button1_Click" Text="Insert" /> &nbsp;
                <asp:Button ID="ButtonUpdate" runat="server" OnClick="Button3_Click" Text="Update" /> &nbsp;
                <asp:Button ID="ButtonDelete" runat="server" OnClick="Button4_Click" Text="Delete" /> &nbsp;
                <asp:Button ID="ButtonSelect" runat="server" OnClick="Button5_Click" Text="Select" /> &nbsp;
                <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 292px">&nbsp;</td>
            <td>
                <asp:Label ID="LInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
