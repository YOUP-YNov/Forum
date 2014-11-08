using Forum.Business;
using Forum.Business.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum.Controllers
{
    /// <summary>
    /// Available method for categories
    /// </summary>
    public class CategoryController : ApiController
    {
        /// <summary>
        /// Get an array of all category informations
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>Array ListCategoryModel</returns>
        [HttpGet]
        [Route("api/Category/ByForum/{IDForum}")]
        public List<CategorieModel> GetListCategory(int IDForum)
        {
            CategorieBusiness categorie = new CategorieBusiness();
            return ConvertModel.ToModel(categorie.GetListCategorie(IDForum));
        }

        [HttpGet]
        [Route("api/Category/{IDCategory}")]
        public CategorieModel GetCategory(int IDCategory)
        {
            CategorieBusiness catbusi = new CategorieBusiness();
            return ConvertModel.ToModel(catbusi.getCategorie(IDCategory)); ;
        }

        [HttpGet]
        [Route("api/Category")]
        public List<CategorieModel> GetCategory()
        {
            CategorieBusiness categorie = new CategorieBusiness();
            return ConvertModel.ToModel(categorie.GetListCategorie());
        }

        /// <summary>
        /// Create a forum with his name and the forum id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <param name="Name">forum name</param>
        [HttpPost]
        [Route("api/Category")]
        public bool CreateCategory(int IDForum, string Name)
        { 
            CategorieB cat = new CategorieB();
            cat.Forum_id = IDForum;
            cat.Nom = Name;
            CategorieBusiness catmodel = new CategorieBusiness();
            catmodel.CreateCategorie(cat);
            return true;
        }
        /// <summary>
        /// Edit a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        /// <param name="Name">Name</param>
        [HttpPost]
        [Route("api/Category/Edit")]
        public int EditCategory(int IDCategory, string Name)
        {
            return 1;
        }
        /// <summary>
        /// Delete a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        public bool DeleteCategory(int IDCategory)
        {
            return true;
        }
    }
}
