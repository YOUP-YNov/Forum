using Forum.DAL.Data;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace Forum.DAL
{   
    //public class CategorieDAL
    public partial class CategorieDAL
    {
        [SqlProcedure()]
        //string connexionstring = "data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection myConnection;

        public static void CreateCategorie(SqlInt32 sujet_id, SqlInt32 forum_id, SqlString nom)
        {
            using (SqlConnection conn = new SqlConnection("data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                SqlCommand CreateCategorieCommand = new SqlCommand();
                SqlParameter sujetIdParam = new SqlParameter("@Sujet_id", SqlDbType.BigInt);
                SqlParameter forumIdParam = new SqlParameter("@Forum_id", SqlDbType.BigInt);
                SqlParameter nomParam = new SqlParameter("@nom", SqlDbType.NVarChar);

                sujetIdParam.Value = sujet_id;
                forumIdParam.Value = forum_id;
                nomParam.Value = nom;

                CreateCategorieCommand.Parameters.Add(sujetIdParam);
                CreateCategorieCommand.Parameters.Add(forumIdParam);
                CreateCategorieCommand.Parameters.Add(nomParam);

                CreateCategorieCommand.CommandText =
                    "INSERT [dbo].[FOR_Sujet] (Sujet_id, Forum_id, Nom)" +
                    " VALUES(@Sujet_id, @Forum_id, Nom)";

                CreateCategorieCommand.Connection = conn;

                conn.Open();
                CreateCategorieCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        /*
        public CategorieDAL()
        {
            myConnection = new SqlConnection(connexionstring);
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void CreateCategorie(CategorieD cat)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "INSERT INTO FOR_Sujet (Sujet_id, Forum_id, Nom) "
                    + "Values (" + cat.Sujet_id + ", " + cat.Forum_id + ", '" + cat.Nom + "')";
                command.ExecuteNonQuery();
            }
        }
        */
        public void EditCategorie(CategorieD cat)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "UPDATE FOR_Sujet SET Nom = '" + cat.Nom + "' WHERE Topic_id = " + cat.Sujet_id;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCategorie(int id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM FOR_Sujet WHERE Sujet_id = " + id;
                command.ExecuteNonQuery();
            }
        }

        public List<CategorieD> GetListCategorie()
        {
            List<CategorieD> ListC = new List<CategorieD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Sujet", myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListC.Add(new CategorieD
                        {
                            Forum_id = Convert.ToInt32(reader["Forum_id"]),
                            Nom = reader["Nom"].ToString(),
                            Sujet_id = Convert.ToInt32(reader["Sujet_id"])
                        });
                    }
                }
            }
            return ListC;
        }

        public List<CategorieD> GetListCategorie(int forum_id)
        {
            List<CategorieD> ListC = new List<CategorieD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Sujet WHERE Forum_id = " + forum_id, myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListC.Add(new CategorieD
                        {
                            Forum_id = Convert.ToInt32(reader["Forum_id"]),
                            Nom = reader["Nom"].ToString(),
                            Sujet_id = Convert.ToInt32(reader["Sujet_id"])
                        });
                    }
                }
            }
            return ListC;
        }

        public void Dispose()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

   
}