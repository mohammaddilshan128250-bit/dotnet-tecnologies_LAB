<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Totals.aspx.cs" Inherits="Practical_09_Placement_Dashboard.Totals" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Totals</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Placement Totals</h1>

        <p>
            <a href="PlacementDashboard.aspx">Dashboard</a> |
            <a href="Students.aspx">Students</a> |
            <a href="Placements.aspx">Placements</a> |
            <a href="Totals.aspx">Placement Totals</a>
        </p>

        <hr />

        <h2>Company-wise Placement Statistics</h2>

        <asp:GridView ID="gvTotals" runat="server"
            AutoGenerateColumns="true"
            BorderWidth="1"
            CellPadding="8">
        </asp:GridView>

        <h2>Overall Statistics</h2>

        <p>
            Total Placements:
            <asp:Label ID="lblTotalPlacements" runat="server" Text="0" />
        </p>

        <p>
            Total Companies:
            <asp:Label ID="lblTotalCompanies" runat="server" Text="0" />
        </p>

        <p>
            Overall Average Package:
            <asp:Label ID="lblOverallAverage" runat="server" Text="0.00" />
            LPA
        </p>

    </form>
</body>
</html>
