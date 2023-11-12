<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto;border:5px solid black">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Student ID" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtStudentID" runat="server" Font-Size="Medium"></asp:TextBox>
                    &nbsp;
                        <asp:Button ID="txtGet" runat="server" Text="Get" Font-Bold="True" Font-Size="Medium" OnClick="btnGet_Click" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Student Name" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtStudentName" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlAddress" runat="server" Font-Size="Medium" OnSelectedIndexChanged="ddlAddress_SelectedIndexChanged">
                            <asp:ListItem>INDIA</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Age" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Contact" Font-Bold="True" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" Font-Bold="True" Font-Size="Medium" OnClick="btnInsert_Click" />
                    &nbsp;
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" Font-Bold="True" Font-Size="Medium" OnClick="btnUpdate_Click" />
                    &nbsp;
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" Font-Bold="True" Font-Size="Medium" OnClientClick="return confirm('Are You Sure To Delete?');" OnClick="btnDelete_Click" />
                    &nbsp;
                        <asp:Button ID="btnSearch" runat="server" Text="Search" Font-Bold="True" Font-Size="Medium" OnClick="btnSearch_Click" />
                    </td>
                </tr>

                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Font-Bold="True" Width="955px"></asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
