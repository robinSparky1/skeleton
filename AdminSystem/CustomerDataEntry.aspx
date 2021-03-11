<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="ibl">
            CustomerName<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
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
        <p id="lblAccountVerified">
            Account Verified<asp:TextBox ID="txtAccountVerified" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
