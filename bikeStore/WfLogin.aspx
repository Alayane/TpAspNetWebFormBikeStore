<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfLogin.aspx.cs" Inherits="bikeStore.WfLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">email</td>
                    <td>
                        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtEmail" ErrorMessage="eamil required" ValidateRequestMode="Enabled" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">mot de pass</td>
                    <td>
                        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPassword" ErrorMessage="password required" ValidateRequestMode="Enabled" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="btnLogin" runat="server" Text="login" OnClick="btnLogin_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /> 

    </form>
</body>
</html>
