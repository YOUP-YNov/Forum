using Forum.Business.Data;
using Forum.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Business
{
    public class TopicBusiness
    {
        public TopicB getTopic(int id) {

            TopicDAL topic = new TopicDAL();
            return ConvertBusiness.ToBusiness(topic.GetTopic(id)); 
        }

          
    }
}