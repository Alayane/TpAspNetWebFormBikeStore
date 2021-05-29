﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfCategory.aspx.cs" Inherits="bikeStore.WfCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id :"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />   
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />   
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />   
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />   
    
        </div>
    </form>
</body>
</html>
