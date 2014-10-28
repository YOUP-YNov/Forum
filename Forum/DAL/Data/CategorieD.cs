using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.DAL.Data
{
    public class CategorieD
    {
        public int id { get; set; }
        public String name { get; set; }
        public int forum_id { get; set; }
    }
}