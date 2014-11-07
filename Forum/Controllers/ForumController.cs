using Forum.Business;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            ForumBusiness forum = new ForumBusiness();
            return ConvertModel.ToModel(forum.GetListForum());
        }

        /// <summary>
        /// Get a forum information by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>ForumModel ForumModel</returns>
        public int GetForum(int IDForum)
        {
            ForumBusiness forum = new ForumBusiness();
            return ConvertModel.ToModel(forum.getForum(IDForum));
        }
        /// <summary>
        /// Create a forum with his name
        /// </summary>
        /// <param name="Name">Name of the forum</param>
        public void CreateForum(string Name)
        {
            ForumModel NewForum = new ForumModel();
            NewForum.Nom = Name;
            NewForum.Url = string.Empty;
            ForumBusiness forum = new ForumBusiness();
            forum.CreateForum(ConvertModel.ToBusiness(NewForum));
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
