<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfGridView.aspx.cs" Inherits="bikeStore.WfGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlFilter" runat="server" OnSelectedIndexChanged="ddlFilter_SelectedIndexChanged" >
                <asp:ListItem Value="1">year</asp:ListItem>
                <asp:ListItem Value="2">brand</asp:ListItem>
                <asp:ListItem Value="3">categorey</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" Text="Filtrer" OnClick="btnFilter_Click" />
            <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
