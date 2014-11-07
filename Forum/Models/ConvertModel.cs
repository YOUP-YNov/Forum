using AutoMapper;
using Forum.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ConvertModel
    {

        public static TopicModel ToModel(TopicController topic)
        {
            Mapper.CreateMap<TopicController, TopicModel>();
            return Mapper.Map<TopicController, TopicModel>(topic);
        }
        internal static List<TopicModel> ToModel(List<TopicController> listtopicc)
        {
            List<TopicModel> listtopicm = new List<TopicModel>();
            Mapper.CreateMap<TopicController, TopicModel>();

            foreach (var topicm in listtopicc)
            {
                listtopicm.Add(Mapper.Map<TopicController, TopicModel>(topicm));
            }
            return listtopicm;
        }
    }
}