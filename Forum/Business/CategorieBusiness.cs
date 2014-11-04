using Forum.Business.Data;
using Forum.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Business
{
    public class CategorieBusiness
    {
        public List<CategorieB> GetListCategorie(int id)
        {

            CategorieDAL categorie = new CategorieDAL();
            return ConvertBusiness.ToBusiness(categorie.GetListCategorie(id));
        }
        public /*CategorieB*/ void EditCategorie(int id)
        {
            CategorieDAL categorie = new CategorieDAL();
            //return ConvertBusiness.ToBusiness(categorie.GetListCategorie(id));
        }
        public /*CategorieB*/ void DeleteCategorie(int id)
        {
            CategorieDAL categorie = new CategorieDAL();
            //return ConvertBusiness.ToBusiness(categorie.GetCategorie(id));
        }
    }
}