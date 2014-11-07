using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class CategorieModel
    {
        public long Sujet_id { get; set; }
        public long Forum_id { get; set; }
        public string Nom { get; set; }
    }

          public bool CreateCategorie(CategorieD cat)
        {

        }
        
        public bool EditCategorie(CategorieD cat)
        {

        }

        public bool DeleteCategorie(int id)
        {

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
}