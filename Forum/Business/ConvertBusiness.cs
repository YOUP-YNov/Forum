﻿using AutoMapper;
using Forum.Business.Data;
using Forum.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Business
{
    public static class ConvertBusiness
    {
        public static ForumB ToBusiness(ForumD forum)
        {
            Mapper.CreateMap<ForumD, ForumB>();
            return Mapper.Map<ForumD, ForumB>(forum);
        }

        public static TopicB ToBusiness(TopicD topic)
        {
            Mapper.CreateMap<TopicD,TopicB>();
            return Mapper.Map<TopicD, TopicB>(topic);
        }

       

        public static CategorieB ToBusiness(CategorieD categorie)
        {
            Mapper.CreateMap<CategorieD, CategorieB>();
            return Mapper.Map<CategorieD, CategorieB>(categorie);
        }

        public static MessageB ToBusiness(MessageD message)
        {
            Mapper.CreateMap<MessageD, MessageB>();
            return Mapper.Map<MessageD, MessageB>(message);
        }
    }
}