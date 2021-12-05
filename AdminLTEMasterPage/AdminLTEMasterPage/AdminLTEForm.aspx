<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLTE.Master" AutoEventWireup="true" CodeBehind="AdminLTEForm.aspx.cs" Inherits="AdminLTEMasterPage.AdminLTEForm" %>


<asp:Content ContentPlaceHolderID="title" runat="server">
    Employee Form
</asp:Content>

<asp:Content ContentPlaceHolderID="breadcrumb" runat="server">
    Employee Form
</asp:Content>

<asp:Content ContentPlaceHolderID="contentHeader" runat="server">
    Employee Form
</asp:Content>

<asp:Content ContentPlaceHolderID="maincontent" runat="server">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label1" runat="server" Text="ID" Font-Bold="True" ></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>

                    <td class="auto-style9" style="width: 38px;">
                        <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-info" OnClick="btnSearch_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label3" runat="server" Text="First Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label4" runat="server" Text="Last Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" ></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label5" runat="server" Text="Education" Font-Bold="True" ></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtEducation" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label6" runat="server" Text="Department" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtDepartment" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label7" runat="server" Text="Salary" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label2" runat="server" Text="Role" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtRole" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" CssClass="btn btn-info" OnClick="btnInsert_Click" Text="Insert"/>
                        <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-secondary" OnClick="btnUpdate_Click" Text="Update" />
                        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" OnClick="btnDelete_Click" Text="Delete" />
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style10" style="width: 32px">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:GridView ID="dataGridView" CssClass="table table-striped" runat="server" Width="295px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td style="width: 32px">
                        &nbsp;</td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td class="auto-style9" style="width: 38px">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>