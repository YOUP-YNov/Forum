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
        public TopicB getTopic(int id)
        {

            TopicDAL topicdal = new TopicDAL();
            return ConvertBusiness.ToBusiness(topicdal.GetTopic(id));
        }
        public bool EditTopic(TopicB topic)
        {
            TopicDAL topicdal = new TopicDAL();
            TopicB topic = ConvertBusiness.ToBusiness(topicdal.GetTopic(topic));
            topic.Nom = Titre;
            //topicdal.EditTopic(ConvertBusiness.ToDAL(topicB));            
        }
        public List<TopicB> GetListTopic()
        {

            TopicDAL topicdal = new TopicDAL();
            // TODO
            return ConvertBusiness.ToBusiness(topicdal.GetListTopic());
        }
       /* public TopicModel GetTopicByEvent()
        {
            TopicDAL topicdal = new TopicDAL();
            return ConvertBusiness.ToBusiness(topicdal.GetTopicByEvent());

        }*/
        public bool CreateTopic(int IDcategory, string Name, string Contenu)
        {
            TopicDAL topicdal = new TopicDAL();
            return ConvertBusiness.ToBusiness(topicdal.ToDAL(forB));
        }
        public bool DeleteTopic(int id)
        {
            TopicDAL topicB = new TopicDAL();
            return topicB.DeleteTopic(id);
        }


    }
}