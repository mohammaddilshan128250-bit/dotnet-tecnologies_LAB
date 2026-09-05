<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" 
    Inherits="Experiment5.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
            height: 182px;
        }

        .auto-style2 {
            width: 205px;
        }

        #Password1 {
            height: 32px;
            width: 217px;
        }

        #txtpassword {
            height: 35px;
            width: 214px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login Page for Leave application</h2>
        </div>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Username</td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"
                        Height="33px" Width="217px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style2">password</td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server"
                        Height="33px" TextMode="Password"
                        Width="217px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

        <asp:Button ID="btlogin" runat="server"
            OnClick="btlogin_Click"
            Text="login"
            Width="147px" />

        <p>
            <asp:Label ID="lblmessage" runat="server"
                CssClass="error"
                BackColor="White"
                BorderColor="#003300"
                ForeColor="#FF3300">
            </asp:Label>
        </p>
    </form>
</body>
</html>
