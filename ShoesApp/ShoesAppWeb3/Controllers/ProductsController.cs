using ShoesAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace ShoesAppWeb3.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
            DataProductsEntities DTE = new DataProductsEntities();
            
            return View(DTE.BRTV_Show());
        }
    }
}