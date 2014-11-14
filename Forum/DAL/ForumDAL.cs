using Forum.DAL.Data;
using Forum.myDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Forum.DAL
{
    public class ForumDAL
    {
        SqlConnection myConnection;

        public bool CreateForum(ForumD forum)
        {
            try
            {
                using (ps_FOR_GetForumTableAdapter ForumTable = new ps_FOR_GetForumTableAdapter())
                {
                    ForumTable.ps_FOR_CreateForum(forum.Forum_id, forum.Nom, forum.Url);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditForum(ForumD forum)
        {
            try
            {
                using (ps_FOR_GetForumTableAdapter ForumTable = new ps_FOR_GetForumTableAdapter())
                {
                    ForumTable.ps_FOR_UpdateForum(forum.Forum_id, forum.Nom);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteForum(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    command.CommandText = "DELETE FROM FOR_Forum WHERE Forum_id = " + id;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ForumD> GetListForum()
        {
            List<ForumD> ListF = new List<ForumD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Forum", myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListF.Add(new ForumD
                        {
                            Forum_id = Convert.ToInt32(reader["Forum_id"]),
                            Nom = reader["Nom"].ToString(),
                            Url = reader["Url"].ToString()
                        });
                    }
                }
            }
            return ListF;
        }

        public ForumD GetForum(int id)
        {
            ForumD forum = new ForumD();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Forum WHERE Forum_id = " + id, myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        forum.Nom = reader["Nom"].ToString();
                        forum.Url = reader["Url"].ToString();
                    }
                }
            }
            return forum;
        }
    }
}