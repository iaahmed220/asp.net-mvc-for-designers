using Store.Models;
using Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            ShoppingIndexViewModel model = new ShoppingIndexViewModel();
            model.Products = new List<Product>();
            model.Products.Add(new Product
            {
                ProductName = "Beard Wax",
                ProductPrice = "$5.00",
                ProductDescription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.",
                ProductID = 1
            });

            model.Products.Add(new Product
            {
                ProductName = "Tree Axe",
                ProductPrice = "$25.00",
                ProductDescription = "Ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.",
                ProductID = 2
            });

            model.Products.Add(new Product
            {
                ProductName = "Flannel Shirt",
                ProductPrice = "$45.00",
                ProductDescription = "Solor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.",
                ProductID = 3
            });

            model.Products.Add(new Product
            {
                ProductName = "Suspenders",
                ProductPrice = "$8.50",
                ProductDescription = "Consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.",
                ProductID = 4
            });

            model.Customer = new Customer();
            model.Customer.FirstName = "Craig";
            model.Customer.LastName = "Campbell";
            return View(model);
        }
    }
}