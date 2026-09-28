using System.Collections.Generic;
using System.Web.Mvc;
using Practical_06_Product_Catalog_MVC.Models;

namespace Practical_06_Product_Catalog_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Products> products = new List<Products>();

            Products p1 = new Products();
            p1.pID = 101;
            p1.pName = "Laptop";
            p1.pCategory = "Tech";
            p1.pPrice = 130000;
            p1.pDescription = "Lenovo Legion 5 Laptop with 8GB RAM, 2TB SSD";

            Products p2 = new Products();
            p2.pID = 102;
            p2.pName = "Mobile";
            p2.pCategory = "Tech";
            p2.pPrice = 400000;
            p2.pDescription = "IPhone DUO. Base Model";

            Products p3 = new Products();
            p3.pID = 103;
            p3.pName = "A4 Book";
            p3.pCategory = "Edu";
            p3.pPrice = 50;
            p3.pDescription = "An A4 book with ruler pages";

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return View("productsView", products);
        }
    }
}
