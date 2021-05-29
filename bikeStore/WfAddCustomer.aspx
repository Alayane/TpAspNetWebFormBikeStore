<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfAddCustomer.aspx.cs" Inherits="bikeStore.WfAddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1">
        
        <tr>
            <td class="auto-style2">prenom&nbsp;</td>
            <td>
                <asp:TextBox ID="txtPrenom" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtPrenom" ErrorMessage="prenom est obligatiore" 
                Text="*" SetFocusOnError="True" ValidateRequestMode="Enabled" >*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">nom</td>
            <td>
                <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNom" ErrorMessage="Required">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">phone</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                runat="server" ControlToValidate="txtPhone" 
                ErrorMessage="le format de numero n'est pas valide" 
                SetFocusOnError="True" ValidateRequestMode="Enabled"
                ValidationExpression="0\d{9}">*</asp:RegularExpressionValidator> 
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">adress</td>
            <td>
                <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">ville</td>
            <td>
                <asp:TextBox ID="txtVille" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">region</td>
            <td>
                <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">code postal </td>
            <td>
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
        <asp:Button ID="btnAjouter" runat="server" OnClick="btnAjouter_Click" Text="Ajouter" />
       <br /> <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       <br /> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">retour</asp:LinkButton>
       <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
    </body>
</html>
