using ShoesAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesAppWeb3;
using System.Data.SqlClient;

namespace ShoesAppWeb3.Controllers
{
    public class ProductsController : Controller
    {
        DataProductsEntities DTE = new DataProductsEntities();
        AddProdET AddET = new AddProdET();

        // GET: Products
        public ActionResult Products()
        {
            DataProductsEntities DTE = new DataProductsEntities();
            
            return View(DTE.BRTV_Show());
        }

        [HttpGet]
        public ActionResult InsertProducts()
        {

            return View();
        }

        [HttpPost]

        public ActionResult InsertProducts(AddProdET AddET)
        {
            try
            {
                
                CapaDatos capaDatos = new CapaDatos();
                capaDatos.Insert(AddET);
               // DataProductsEntities DTE = new DataProductsEntities();

               // AddET.DateUpdate = DateTime.Now;

               // DTE.BRTV_Insert(AddET.IdType, AddET.IdColor, AddET.IdBrand, AddET.IdProvider, AddET.IdCatalog, AddET.Title, AddET.Nombre, AddET.Description,
               //AddET.Observations, AddET.PriceDistributor, AddET.PriceClient, AddET.PriceMember, AddET.IsEnabled, AddET.Keywords, AddET.DateUpdate);
               // //products.DateUpdate = DateTime.Now;

                return RedirectToAction("Products");

            }
            catch (Exception)
            {



                throw;
            }
        }
    }
}