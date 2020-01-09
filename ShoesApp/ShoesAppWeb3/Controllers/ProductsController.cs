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
        public ActionResult Products(string name)
        {


            try
            {
             
                var x = from s in DTE.BRTV_Show()
                        select s;

                if (!String.IsNullOrEmpty(name))
                {

                    x = DTE.BRTV_Show().Where(a => a.Nombre.Contains(name));


                }




                return View(x.ToList());
            }
            catch (Exception)
            {
                throw;
            }



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
        [HttpGet]
        public ActionResult Edit(int id)
        {



            using (var db = new DataProductsEntities())
            {
                BRTV_Show_Result x = db.BRTV_Show().Where(a => a.Id == id).FirstOrDefault();

                return View();
            }


        }

        [HttpPost]

        public ActionResult Edit(AddProdET AddET)
        {
            try
            {

                CapaDatos capaDatos = new CapaDatos();
                capaDatos.Update(AddET);


                return RedirectToAction("Products");

            }
            catch (Exception)
            {



                throw;
            }
        }
       
        public ActionResult Delete(int id)
        {


            using (var db = new DataProductsEntities())
            {
                BRTV_Show_Result x = db.BRTV_Show().Where(a => a.Id == id).FirstOrDefault();

                return View(x);
            }


        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            try
            {

                using (var db = new DataProductsEntities())
                {
                    BRTV_Show_Result x = db.BRTV_Show().Where(a => a.Id == id).FirstOrDefault();
                    CapaDatos capaDatos = new CapaDatos();
                    capaDatos.Delete(id);




                    return RedirectToAction("Products");
                }

            }
            catch (Exception)
            {



                throw;
            }
        }
       

    }
}
