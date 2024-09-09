using LabTask5.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LabTask5.Models;

namespace LabTask5.Controllers
{
    public class ProductController : Controller
    {
        AppContextModel _dbContext;
        public ProductController()
        {
            _dbContext = new AppContextModel();
        }
        // GET: Product
        public ActionResult ViewProduct()
        {
            var productList = _dbContext.Product.Include(m =>  m.Category).ToList();
            return View(productList);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p) // Action method overloading
        {
                _dbContext.Product.Add(p);
                _dbContext.SaveChanges();

                return RedirectToAction("ViewProduct");

        }
    }
}