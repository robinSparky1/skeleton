﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="ibl">
            AccountNo<asp:TextBox ID="txtAccountNo" runat="server"></asp:TextBox>
            <br />
            CustomerName<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p id="lblCustomerEmail">
            Email<asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        </p>
        <p id="lblDateAdded">
            DateAdded<asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <p id="lblDateOfBirth">
            Date Of Birth<asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            Ballance<asp:TextBox ID="txtBallance" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAccountVerified" runat="server" Text="Account Verified" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
