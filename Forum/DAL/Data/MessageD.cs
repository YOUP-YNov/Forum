using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.DAL.Data
{
    public class MessageD
    {
        public int id { get; set; }
        public String content { get; set; }
        public int date { get; set; }
        public int topic_id { get; set; }
        public int user_id { get; set; }
    }
}