<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Practical_08_Inventory_Management.Inventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hfProductId" runat="server" />

        <div>
            <h3>Add New Product</h3>
            <table>
                <tr>
                    <td>Product Name:</td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Category:</td>
                    <td>
                        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Price:</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Quantity:</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button
                            ID="btnAddProduct"
                            runat="server"
                            Text="Add Product"
                            OnClick="btnAddProduct_Click" />
                    </td>
                </tr>
            </table>
            <br />

            <div>
                <h2>Inventory Management System</h2>

                    <asp:GridView
                        ID="GridViewProducts"
                        runat="server"
                        AutoGenerateColumns="true"
                        DataKeyNames="ProductId"
                        OnSelectedIndexChanged="GridViewProducts_SelectedIndexChanged"
                        BorderWidth="1"
                        CellPadding="8"
                        OnRowDeleting="GridViewProducts_RowDeleting">

                        <Columns>
                            <asp:CommandField
                                ShowSelectButton="true"
                                SelectText="Edit" />
                            <asp:CommandField
                                ShowDeleteButton="true"
                                DeleteText="Delete" />
                        </Columns>

                    </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
