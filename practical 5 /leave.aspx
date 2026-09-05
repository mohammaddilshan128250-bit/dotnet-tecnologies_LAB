<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave.aspx.cs"
    Inherits="Experiment5.leave" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave application</title>

    <style type="text/css">
        .auto-style1 {
            width: 59%;
            height: 350px;
        }

        .auto-style2 {
            width: 205px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div id="btnlogout">
            Welcome to Leave app&nbsp;,
            <asp:Label ID="lblusername" runat="server"
                CssClass="error">
            </asp:Label>

            <table class="auto-style1">

                <tr>
                    <td class="auto-style2">
                        Username
                    </td>

                    <td>
                        <asp:TextBox
                            ID="txtUsername"
                            runat="server"
                            CssClass="input">
                        </asp:TextBox>
                    </td>
                </tr>

                <!-- From Date -->
                <tr>
                    <td class="auto-style2">
                        From Date
                    </td>

                    <td>
                        <asp:TextBox
                            ID="txtFromDate"
                            runat="server"
                            CssClass="input"
                            TextMode="Date">
                        </asp:TextBox>
                    </td>
                </tr>

                <!-- To Date -->
                <tr>
                    <td class="auto-style2">
                        To Date
                    </td>

                    <td>
                        <asp:TextBox
                            ID="txtToDate"
                            runat="server"
                            CssClass="input"
                            TextMode="Date">
                        </asp:TextBox>
                    </td>
                </tr>

                <!-- Leave Type -->
                <tr>
                    <td class="auto-style2">
                        Leave Type
                    </td>

                    <td>
                        <asp:DropDownList
                            ID="ddlLeaveType"
                            runat="server"
                            CssClass="input">

                            <asp:ListItem
                                Text="-- Select Leave Type --"
                                Value="">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="Casual Leave"
                                Value="Casual Leave">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="Sick Leave"
                                Value="Sick Leave">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="Emergency Leave"
                                Value="Emergency Leave">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="Personal Leave"
                                Value="Personal Leave">
                            </asp:ListItem>

                        </asp:DropDownList>
                    </td>
                </tr>

                <!-- Leave Reason -->
                <tr>
                    <td class="auto-style2">
                        Leave Reason
                    </td>

                    <td>
                        <asp:TextBox
                            ID="txtReason"
                            runat="server"
                            CssClass="input"
                            TextMode="MultiLine">
                        </asp:TextBox>

                        &nbsp;
                    </td>
                </tr>

            </table>

            <!-- Submit -->
            <asp:Button
                ID="btnApply"
                runat="server"
                Text="Apply Leave"
                CssClass="btn"
                OnClick="btnApply_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button
                ID="btnlogout"
                runat="server"
                OnClick="btnlogout_Click"
                Text="Logout" />

            <br />
            <br />

            <asp:Label
                ID="label1"
                runat="server">
            </asp:Label>

            <br />
            <br />

            <!-- result -->

            <asp:Label
                ID="lblResultUsername"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:Label
                ID="lblResultFromDate"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:Label
                ID="lblResultToDate"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:Label
                ID="lblResultLeaveType"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:Label
                ID="lblResultReason"
                runat="server">
            </asp:Label>

        </div>

    </form>
</body>
</html>
