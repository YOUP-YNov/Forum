using Forum.Business.Data;
using Forum.DAL;
using Forum.Models;
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


        public void EditTopic(int id, string Titre)
        {
            TopicDAL topicdal = new TopicDAL();
            TopicB topicb = ConvertBusiness.ToBusiness(topicdal.GetTopic(id));
            topicb.Nom = Titre;
            //topicdal.EditTopic(ConvertBusiness.ToDAL(topicB));            
        }

        public List<TopicB> GetListTopic()
        {

            TopicDAL topic = new TopicDAL();
            // TODO
            return null;

        }

        
    }
}