<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownListShow.aspx.cs" Inherits="_110_1HW5.DropdownListShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Area" runat="server" OnSelectedIndexChanged="ddl_Area_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList ID="ddl_Place" runat="server"  AutoPostBack="True"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
