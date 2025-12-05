<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientTimeOut.aspx.cs" Inherits="_04_ClientTimeOutWebService.ClientTimeOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="font-family:Arial" >
                <tr>
                    <td>
                        <asp:Button ID="btnTimeOut" runat="server" Text="GetResponse" OnClick="btnTimeOut_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblResponse" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
