using Forum.DAL.Data;
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
        }
        public void CreateCategorie(CategorieD cat)
        {
            try 
            {
                myConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void EditCategorie(CategorieD cat)
        {

        }

        public void DeleteCategorie(int id)
        {

        }

        public List<CategorieD> GetCategorie()
        {
            return null;
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