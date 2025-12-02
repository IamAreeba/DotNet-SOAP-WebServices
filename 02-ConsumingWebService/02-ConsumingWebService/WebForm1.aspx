<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_02_ConsumingWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial,'Segoe UI'">
                <tr>
                    <td>FirstValue</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtFirstValue" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>SecondValue</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtSecondValue" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Operation</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtOperation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="right">
                        <asp:Button ID="btnDivision" runat="server" OnClick="btnDivision_click" Text="Divide" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>


</body>
</html>
