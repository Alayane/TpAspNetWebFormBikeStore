<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfListCustomers.aspx.cs" Inherits="bikeStore.WfListCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Liste des clients&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnAjoute" runat="server" OnClick="btnAjoute_Click">Ajouter nouveau client</asp:LinkButton>
            </h1>
            <asp:GridView ID="gvClients" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowDeleting="gvClients_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="customer_id" HeaderText="Id" SortExpression="customer_id" />
                    <asp:BoundField DataField="first_name" HeaderText="prenom" SortExpression="first_name" />
                    <asp:BoundField DataField="last_name" HeaderText="nom" SortExpression="last_name	" />
                    <asp:BoundField DataField="phone" HeaderText="telephone" SortExpression="phone" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                    <asp:BoundField DataField="street" HeaderText="adress" SortExpression="street" />
                    <asp:BoundField DataField="city" HeaderText="ville" SortExpression="city" />
                    <asp:BoundField DataField="state" HeaderText="region" SortExpression="state" />
                    <asp:BoundField DataField="zip_code" HeaderText="code postale" SortExpression="zip_code" />
                    <asp:ButtonField CommandName="Delete" HeaderText="Suppréssion" ShowHeader="True" Text="Supprimer" />
                    <asp:HyperLinkField DataNavigateUrlFields="customer_id,first_name,last_name,phone,email,street,city,state,zip_code" DataNavigateUrlFormatString="WfModifierCustomer.aspx?id={0}&amp;prenom={1}&amp;nom={2}&amp;email={3}&amp;phone={4}&amp;adress={5}&amp;ville={6}&amp;region={7}&amp;code={8}" HeaderText="modification" Text="modifier" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
