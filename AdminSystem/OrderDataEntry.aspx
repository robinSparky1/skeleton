<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="lblOrderNo">
    <form id="form1" runat="server">
        <asp:Label ID="lblAddressNo" runat="server" Text="Address Number"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderNumber" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <br />
        Item Count&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtItemCount" runat="server" OnTextChanged="txtItemCount_TextChanged"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        OrderPrice&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
        
        <br />
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Purchase Date" Width="99px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:CheckBox ID="cbPayed" runat="server" Text="Payed" />
&nbsp;<div>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
