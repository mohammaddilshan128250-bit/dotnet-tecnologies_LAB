using Practical_08_Inventory_Management.Data;
using Practical_08_Inventory_Management.Models;
using System;
using System.Web.UI.WebControls;

namespace Practical_08_Inventory_Management
{
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            InventoryRepository repository = new InventoryRepository();

            GridViewProducts.DataSource = repository.GetAllProducts();
            GridViewProducts.DataBind();
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = txtProductName.Text,
                Category = txtCategory.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text)
            };

            InventoryRepository repository = new InventoryRepository();

            if (string.IsNullOrEmpty(hfProductId.Value))
            {
                repository.AddProduct(product);
            }
            else
            {
                product.ProductId = Convert.ToInt32(hfProductId.Value);
                repository.UpdateProduct(product);
            }

            LoadProducts();
            ClearForm();
        }

        private void ClearForm()
        {
            hfProductId.Value = "";
            txtProductName.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            btnAddProduct.Text = "Add Product";
        }

        protected void GridViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(
                GridViewProducts.SelectedDataKey.Value
            );

            InventoryRepository repository = new InventoryRepository();

            Product product = repository.GetAllProducts()
                .Find(p => p.ProductId == productId);

            hfProductId.Value = product.ProductId.ToString();

            txtProductName.Text = product.ProductName;
            txtCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();

            btnAddProduct.Text = "Update Product";
        }

        protected void GridViewProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(
                GridViewProducts.DataKeys[e.RowIndex].Value
            );

            InventoryRepository repository = new InventoryRepository();
            repository.DeleteProduct(productId);

            LoadProducts();
        }
    }
}
