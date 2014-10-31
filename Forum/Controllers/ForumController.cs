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
    /// Available method for forums
    /// </summary>
    public class ForumController : ApiController
    {
        /// <summary>
        /// Get an array of all forum informations
        /// </summary>
        /// <returns>Array</returns>
        public List<ForumModel> GetListForum()
        {
            return null;
        }

        /// <summary>
        /// Get a forum information by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>ForumModel ForumModel</returns>
        public ForumModel GetForum(int IDForum)
        {
            return null;
        }
        /// <summary>
        /// Create a forum with his name
        /// </summary>
        /// <param name="Name">Name of the forum</param>
        public void CreateForum(string Name)
        {
        }
        /// <summary>
        /// Edit a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public void EditForum(int IDForum, string title)
        {
        }
        /// <summary>
        /// Delete a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public void DeleteForum(int IDForum)
        {
        }
    }
}
