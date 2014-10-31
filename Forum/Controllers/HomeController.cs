using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        string connexionstring = "data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection myConnection;
        
        public ActionResult Index()
        {
            myConnection = new SqlConnection(connexionstring);
            ViewBag.Title = "Home Page";
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return View();
        }
    }
}
