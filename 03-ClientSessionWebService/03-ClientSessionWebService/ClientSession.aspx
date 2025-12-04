<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientSession.aspx.cs" Inherits="_03_ClientSessionWebService.ClientSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial">
                <tr>
                    <td>Enter Name</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="btnGetNames" runat="server" Text="GetNames" OnClick="btnGetNames_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="gvGetNames" runat="server"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGetCount" runat="server" Text="GetCount" OnClick="btnGetCount_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblGetCount" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
