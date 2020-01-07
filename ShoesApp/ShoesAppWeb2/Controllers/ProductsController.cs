using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace ShoesAppWeb2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ShowProducts()
        {

            Data.CapaDatos cd = new Data.CapaDatos();
            return View(cd.Show1());
        }
    }
}