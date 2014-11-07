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
            List<ForumModel> lt = ConvertModel.ToModel(forum.GetListForum());
            return lt;
        }

        /// <summary>
        /// Get a forum information by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>ForumModel ForumModel</returns>
        public int GetForum(int IDForum)
        {
            SqlConnection myConnection;
            int rowsAffected;

                myConnection = new SqlConnection("data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "ps_FOR_GetForum";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter iffo = new SqlParameter("@Forum_id", SqlDbType.BigInt);
                iffo.Value = IDForum;
                cmd.Parameters.Add(iffo);

                cmd.Connection = myConnection;

                myConnection.Open();

                rowsAffected = cmd.ExecuteNonQuery();

            myConnection.Close();
            return rowsAffected;
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
