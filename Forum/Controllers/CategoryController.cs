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
        public List<CategorieModel> GetListCategory(int IDForum)
        {
            return null;
        }
        /// <summary>
        /// Create a forum with his name and the forum id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <param name="Name">forum name</param>
        public void CreateCategory(int IDForum, string Name)
        {
        }
        /// <summary>
        /// Edit a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        public void EditCategory(int IDCategory)
        {
        }
        /// <summary>
        /// Delete a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        public void DeleteCategory(int IDCategory)
        {
        }
    }
}
