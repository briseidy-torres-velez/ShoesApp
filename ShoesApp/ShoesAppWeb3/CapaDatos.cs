using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoesAppWeb3.Models;

namespace ShoesAppWeb3
{
    public class CapaDatos
    {
        DataProductsEntities DTE  = new DataProductsEntities();
        public List<BRTV_Show_Result> Show1()
        {

            List<BRTV_Show_Result> listShow = new List<BRTV_Show_Result>();
            foreach (var item in DTE.Products.ToList())
            {
                BRTV_Show_Result show = new BRTV_Show_Result();

                show.DateUpdate = item.DateUpdate;
                show.Description = item.Description;
                show.Id = item.Id;
                show.IdBrand = item.IdBrand;
                show.IdCatalog = item.IdCatalog;
                show.IdColor = item.IdColor;
                show.IdProvider = item.IdProvider;
                show.IdType = item.IdProvider;
                show.IsEnabled = item.IsEnabled;
                show.Keywords = item.Keywords;
                show.Nombre = item.Nombre;
                show.Observations = item.Observations;
                show.PriceClient = item.PriceClient;
                show.PriceDistributor = item.PriceDistributor;
                show.PriceMember = item.PriceMember;
                show.Title = item.Title;

                listShow.Add(show);
            }
            return listShow;
        }

     

        public List<BRTV_InsertChanges_Result> NewProduct()
        {
            List<BRTV_InsertChanges_Result> list = new List<BRTV_InsertChanges_Result>();
            foreach (var item in DTE.BRTV_InsertChanges())
            {
                BRTV_InsertChanges_Result show = new BRTV_InsertChanges_Result();
                show.DateUpdate = item.DateUpdate;
                show.Description = item.Description;
                show.Id = item.Id;
                show.IdBrand = item.IdBrand;
                show.IdCatalog = item.IdCatalog;
                show.IdColor = item.IdColor;
                show.IdProvider = item.IdProvider;
                show.IdType = item.IdProvider;
                show.IsEnabled = item.IsEnabled;
                show.Keywords = item.Keywords;
                show.Nombre = item.Nombre;
                show.Observations = item.Observations;
                show.PriceClient = item.PriceClient;
                show.PriceDistributor = item.PriceDistributor;
                show.PriceMember = item.PriceMember;
                show.Title = item.Title;
                list.Add(show);
            }
            return list;
        }
        public List<BRTV_UpdateChanges_Result> Changes()
        {
            List<BRTV_UpdateChanges_Result> list = new List<BRTV_UpdateChanges_Result>();
            foreach (var item in DTE.BRTV_UpdateChanges())
            {
                BRTV_UpdateChanges_Result show = new BRTV_UpdateChanges_Result();
                show.DateUpdate = item.DateUpdate;
                show.Description = item.Description;
                show.Id = item.Id;
                show.IdBrand = item.IdBrand;
                show.IdCatalog = item.IdCatalog;
                show.IdColor = item.IdColor;
                show.IdProvider = item.IdProvider;
                show.IdType = item.IdProvider;
                show.IsEnabled = item.IsEnabled;
                show.Keywords = item.Keywords;
                show.Nombre = item.Nombre;
                show.Observations = item.Observations;
                show.PriceClient = item.PriceClient;
                show.PriceDistributor = item.PriceDistributor;
                show.PriceMember = item.PriceMember;
                show.Title = item.Title;
                list.Add(show);
            }
            return list;
        }
        public List<BRTV_SearchID_Result> Search(int Buscador)
        {

            List<BRTV_SearchID_Result> listSearch = new List<BRTV_SearchID_Result>();
            foreach (var item in DTE.BRTV_SearchID(Buscador))
            {

                if (Buscador == item.Id)
                {
                    BRTV_SearchID_Result sID = new BRTV_SearchID_Result();
                    sID.DateUpdate = item.DateUpdate;
                    sID.Description = item.Description;
                    sID.Id = item.Id;
                    sID.IdBrand = item.IdBrand;
                    sID.IdCatalog = item.IdCatalog;
                    sID.IdColor = item.IdColor;
                    sID.IdProvider = item.IdProvider;
                    sID.IdType = item.IdProvider;
                    sID.IsEnabled = item.IsEnabled;
                    sID.Keywords = item.Keywords;
                    sID.Nombre = item.Nombre;
                    sID.Observations = item.Observations;
                    sID.PriceClient = item.PriceClient;
                    sID.PriceDistributor = item.PriceDistributor;
                    sID.PriceMember = item.PriceMember;
                    sID.Title = item.Title;

                    listSearch.Add(sID);
                }
            }
            return listSearch;
        }
        public List<BRTV_SearchName_Result> SearchByName(string Buscador)
        {

            List<BRTV_SearchName_Result> listSearchByName = new List<BRTV_SearchName_Result>();
            foreach (var item in DTE.BRTV_SearchName(Buscador))
            {
                if (Buscador == item.Nombre)
                {
                    BRTV_SearchName_Result sName = new BRTV_SearchName_Result();
                    sName.DateUpdate = item.DateUpdate;
                    sName.Description = item.Description;
                    sName.Id = item.Id;
                    sName.IdBrand = item.IdBrand;
                    sName.IdCatalog = item.IdCatalog;
                    sName.IdColor = item.IdColor;
                    sName.IdProvider = item.IdProvider;
                    sName.IdType = item.IdProvider;
                    sName.IsEnabled = item.IsEnabled;
                    sName.Keywords = item.Keywords;
                    sName.Nombre = item.Nombre;
                    sName.Observations = item.Observations;
                    sName.PriceClient = item.PriceClient;
                    sName.PriceDistributor = item.PriceDistributor;
                    sName.PriceMember = item.PriceMember;
                    sName.Title = item.Title;
                    listSearchByName.Add(sName);
                }
            }

            return listSearchByName;
        }
        public bool Insert(AddProdET AddET)
        {
            AddET.DateUpdate = DateTime.Now;

            DTE.BRTV_Insert(AddET.IdType, AddET.IdColor, AddET.IdBrand, AddET.IdProvider, AddET.IdCatalog, AddET.Title, AddET.Nombre, AddET.Description,
                AddET.Observations, AddET.PriceDistributor, AddET.PriceClient, AddET.PriceMember, AddET.IsEnabled, AddET.Keywords, AddET.DateUpdate);

            return true;

        }
        public void Delete(int ID)
        {
            try
            {
                DTE.BRTV_Delete(ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(AddProdET AddET)
        {
            DTE.BRTV_updateM(AddET.Id, AddET.Title, AddET.Nombre, AddET.Description, AddET.Observations, AddET.PriceClient, AddET.PriceMember, AddET.IsEnabled,
                AddET.IdType, AddET.IdColor, AddET.IdBrand, AddET.IdProvider, AddET.IdCatalog, AddET.PriceDistributor, AddET.Keywords, AddET.DateUpdate);
            return true;
        }
        public void XmlMethod()
        {

        }
    }
}