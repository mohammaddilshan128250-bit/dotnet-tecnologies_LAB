<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration_From.aspx.cs" Inherits="Registration.Registration_From" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 114px;
        }
        .auto-style2 {
            width: 114px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 231px;
            height: 83px;
        }
        .auto-style5 {
            width: 502px;
        }
        .auto-style6 {
            height: 23px;
            width: 502px;
        }
        .auto-style7 {
            width: 114px;
            height: 26px;
        }
        .auto-style8 {
            width: 502px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            ONLINE EVENT REGISTRATION</p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Your Full Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Valid Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox2" ErrorMessage="Invalid Email" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Mobile Number" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter 10 Digit Mobile Number" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" Text="College"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Your College Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Department" Text="computer" />
                    <br />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Department" OnCheckedChanged="RadioButton2_CheckedChanged" Text="IT" />
                    <br />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Department" Text="Mechanical" />
                    <br />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Department" Text="Civil" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Event"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="34px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="157px">
                        <asp:ListItem>Hackathon</asp:ListItem>
                        <asp:ListItem>Biothon</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Gender" Text="Male" />
                    <br />
                    <asp:RadioButton ID="RadioButton6" runat="server" GroupName="Gender" Text="Female" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Skills"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="C#" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Java" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Python" />
                    <br />
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="C" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
                </td>
                <td class="auto-style5">
                    <textarea id="TextArea1" class="auto-style4" name="S1"></textarea>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label10" runat="server" Text="Terms"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="I Accept Trems &amp; Conditions" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Register" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <!-- Remaining empty rows from the original document for spacing -->
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
