﻿using AutoMapper;
using Forum.Controllers;
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

        public static TopicModel ToModel(TopicController topic)
        {
            Mapper.CreateMap<TopicController, TopicModel>();
            return Mapper.Map<TopicController, TopicModel>(topic);
        }
        internal static List<TopicModel> ToModel(List<TopicController> listtopicc)
        {
            List<TopicModel> listtopicm = new List<TopicModel>();
            Mapper.CreateMap<TopicController, TopicModel>();
        internal static List<ForumModel> ToModel(List<Business.Data.ForumB> list)
        {
            List<ForumModel> listforumM = new List<ForumModel>();
            Mapper.CreateMap<ForumB, ForumModel>();

            foreach (var topicm in listtopicc)
            {
                listtopicm.Add(Mapper.Map<TopicController, TopicModel>(topicm));
            }
            return listtopicm;
        }
            foreach (var forumb in list)
            {
                listforumM.Add(Mapper.Map<ForumB, ForumModel>(forumb));
            }
            return listforumM;
        }
    }
}