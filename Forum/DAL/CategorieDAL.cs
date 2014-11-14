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
using Forum.DAL.Data.Mappeur;

namespace Forum.DAL
{   
    public class CategorieDAL
    {
        SqlConnection myConnection;

        string connexionstring = "data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework";
        ps_FOR_CategorieTableAdapter CategorieDal;

        public bool CreateCategorie(SqlInt32 sujet_id, SqlInt32 forum_id, SqlString nom)
        {


            return true;
           /* try
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
            }*/
        }

        public CategorieDAL()
        {
            CategorieDal = new ps_FOR_CategorieTableAdapter();

        }

        //à faire
        public bool CreateCategorie(CategorieD cat)
        {
            int nbrow = CategorieDal.ps_FOR_CreateCategorie(cat.Forum_id, cat.Nom);
            //using (SqlCommand command = new SqlCommand())
            //{
            //    command.Connection = myConnection;
            //    command.CommandText = "INSERT INTO FOR_Sujet (Sujet_id, Forum_id, Nom) "
            //        + "Values (" + cat.Sujet_id + ", " + cat.Forum_id + ", '" + cat.Nom + "')";
            //    command.ExecuteNonQuery();
            //}
            if (nbrow > 0)
            {
                return true;
            }
            return false;
        }
        public bool EditCategorie(CategorieD cat)
        {
            var modif = CategorieDal.ps_FOR_UpdateCategorie(cat.Sujet_id, cat.Nom);
            return true;
        }

        public bool DeleteCategorie(int Sujet_id)
        {
            var del = CategorieDal.ps_FOR_DeleteCategorie(Sujet_id);
            return true;
        }

        public List<CategorieD> GetListCategorie()
        {
            myDataSet.ps_FOR_CategorieDataTable datatable;
            datatable = CategorieDal.ps_FOR_GetListCategorie();
            return CategorieMappeur.ToCategorieD(datatable).ToList();
        }

        public List<CategorieD> GetListCategorieByForum(int forum_id)
        {
            myDataSet.ps_FOR_CategorieDataTable datatable;

            datatable = CategorieDal.ps_FOR_GetListCategorieByForum(forum_id);
            

            return CategorieMappeur.ToCategorieD(datatable).ToList();
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

        internal CategorieD GetCategorie(int id)
        {
            var lol = CategorieDal.ps_FOR_GetCategorie(id);
            return CategorieMappeur.ToCategorieD(lol).ElementAt(0);
        }
    }
}