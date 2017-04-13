<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title>Events Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Fun Times Calendar</h3>
        <asp:Calendar ID="EventCalendar" runat="server" OnSelectionChanged="EventCalendar_SelectionChanged"></asp:Calendar>
        <asp:Label ID="EventLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
