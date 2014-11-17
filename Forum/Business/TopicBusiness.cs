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
        public TopicB GetTopic(int id)
        {

            TopicDAL topicD = new TopicDAL();
            return ConvertBusiness.ToBusiness(topicD.GetTopic(id));
        }
        public bool EditTopic(TopicB Top)
        {
            TopicDAL TopicD = new TopicDAL();
            return TopicD.EditTopic(ConvertBusiness.ToDAL(Top));          
        }
        public List<TopicB> GetListTopic()
        {

            TopicDAL topicD = new TopicDAL();
            // TODO
            return ConvertBusiness.ToBusiness(topicD.GetListTopic());
        }
        public TopicModel GetTopicByEvent()
        {
            //TopicDAL topicdal = new TopicDAL();
            //return ConvertBusiness.ToBusiness(topicdal.GetTopicByEvent());
            return null;
        }
        public bool CreateTopic(TopicB Top)
        {
            TopicDAL topicD = new TopicDAL();
            return topicD.EditTopic(ConvertBusiness.ToDAL(Top));
        }
        public bool DeleteTopic(int id)
        {
            TopicDAL topicD = new TopicDAL();
            return topicD.DeleteTopic(id);
        }

        internal List<TopicB> GetTopicByCategory(int IDCategory)
        {
            TopicDAL topicdal = new TopicDAL();
            return ConvertBusiness.ToBusiness(topicdal.GetTopicByCategory(IDCategory));
        }

        internal TopicB GetTopicByEvent(int IDEvent)
        {
            throw new NotImplementedException();
        }
    }
}