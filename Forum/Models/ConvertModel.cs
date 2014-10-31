using AutoMapper;
using Forum.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ConvertModel
    {
        public static ConvertModel (topicModel){
            Mapper.CreateMap<TopicB, TopicModel>();
            TopicB topicB = Mapper.Map<TopicModel, TopicB>(topicModel);
        }
    }
}
