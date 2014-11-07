using Forum.DAL.Data;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using Forum.myDataSetTableAdapters;

namespace Forum.DAL
{   
    public class CategorieDAL
    {
        SqlConnection myConnection;

        ps_FOR_GetCategorieTableAdapter CategorieDal;

        public bool CreateCategorie(SqlInt32 sujet_id, SqlInt32 forum_id, SqlString nom)
        {
            //CategorieDal.ps_FOR_GetCategorie();
            try
            {                
                myConnection = new SqlConnection("data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework");
                SqlCommand cmd = new SqlCommand();
                Int32 rowsAffected;

                cmd.CommandText = "ps_FOR_GetListCategorie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = myConnection;

                myConnection.Open();

                rowsAffected = cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
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
        public bool EditCategorie(CategorieD cat)
        {
            try
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "UPDATE FOR_Sujet SET Nom = '" + cat.Nom + "' WHERE Topic_id = " + cat.Sujet_id;
                command.ExecuteNonQuery();
            }
                return true;
            }
            catch
            {
                return false;
        }
        }

        public bool DeleteCategorie(int id)
        {
            try
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM FOR_Sujet WHERE Sujet_id = " + id;
                command.ExecuteNonQuery();
            }
                return true;
            }
            catch
            {
                return false;
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