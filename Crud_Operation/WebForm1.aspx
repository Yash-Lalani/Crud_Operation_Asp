<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Crud_Operation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 144px">
    <form id="form1" runat="server">
        <div>
            Name<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            Email<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            Address<asp:TextBox ID="txtAddress" runat="server" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br>
            
            <br />
        </div>
    </form>
</body>
</html>
