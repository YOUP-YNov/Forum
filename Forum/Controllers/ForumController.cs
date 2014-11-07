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
        [HttpGet]
        [Route("api/Forums")]
        /// <summary>
        /// Get an array of all forum informations
        /// </summary>
        /// <returns>Array</returns>
        public List<ForumModel> GetListForum()
        {
            ForumBusiness forum = new ForumBusiness();
            return ConvertModel.ToModel(forum.GetListForum());
        }

        [HttpGet]
        [Route("api/Forum/{IDForum}")]
        /// <summary>
        /// Get a forum information by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>ForumModel ForumModel</returns>
        public ForumModel GetForum(int IDForum)
        {
            ForumBusiness forum = new ForumBusiness();
            return ConvertModel.ToModel(forum.GetForum(IDForum));
        }

        [HttpPost]
        [Route("api/Forum")]
        /// <summary>
        /// Create a forum with his name
        /// </summary>
        /// <param name="Name">Name of the forum</param>
        public bool CreateForum(ForumModel forum)
        {
            /*ForumModel NewForum = new ForumModel();
            NewForum.Nom = Name;
            NewForum.Url = string.Empty;
            ForumBusiness forum = new ForumBusiness();
            forum.CreateForum(ConvertModel.ToBusiness(NewForum));*/
            return true;
        }

        [HttpPost]
        [Route("api/Forum/{id}")]
        /// <summary>
        /// Edit a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public bool EditForum(ForumModel forum)
        {
            return true;
        }

        [HttpDelete]
        [Route("api/Forum/{IDForum}")]
        /// <summary>
        /// Delete a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public bool DeleteForum(int IDForum)
        {
            return true;
        }
    }
}