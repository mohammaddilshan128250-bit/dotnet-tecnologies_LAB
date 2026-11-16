<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Practical_09_Placement_Dashboard.Students" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Students</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Student Details</h1>

        <p>
            <a href="PlacementDashboard.aspx">Dashboard</a> |
            <a href="Students.aspx">Students</a> |
            <a href="Placements.aspx">Placements</a> |
            <a href="Totals.aspx">Placement Totals</a>
        </p>

        <hr />

        <asp:GridView ID="gvStudents" runat="server"
            AutoGenerateColumns="true"
            BorderWidth="1"
            CellPadding="8">
        </asp:GridView>

    </form>
</body>
</html>
