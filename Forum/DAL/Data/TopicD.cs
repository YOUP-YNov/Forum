using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.DAL.Data
{
    public class TopicD
    {
        public int id { get; set; }
        public String name { get; set; }
        public String topicDescription { get; set; }
        public int creationDate { get; set; }
        public int category_id { get; set; }
        public int user_id { get; set; }
    }
}