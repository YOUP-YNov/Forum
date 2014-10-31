﻿using Forum.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Forum.DAL
{
    public class CategorieDAL
    {
        string connexionstring = "metadata=res://*/DAL.Model1.csdl|res://*/DAL.Model1.ssdl|res://*/DAL.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        SqlConnection myConnection;
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
                command.CommandText = "INSERT INTO FOR_Categorie (Sujet_id, Forum_id, Nom) "
                    + "Values (" + cat.Sujet_id + ", " + cat.Forum_id + ", '" + cat.Nom + "')";
                command.ExecuteNonQuery();
            }
        }
        
        public void EditCategorie(CategorieD cat)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "UPDATE FOR_Categorie SET Nom = '" + cat.Nom + "' WHERE Topic_id = " + cat.Sujet_id;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCategorie(int id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM FOR_Categorie WHERE Sujet_id = " + id;
                command.ExecuteNonQuery();
            }
        }

        public List<CategorieD> GetListCategorie()
        {
            List<CategorieD> ListC = new List<CategorieD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Categorie", myConnection))
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