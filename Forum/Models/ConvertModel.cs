﻿using AutoMapper;
using Forum.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ConvertModel
    {
        internal static List<ForumModel> ToModel(List<Business.Data.ForumB> list)
        {
            List<ForumModel> listforumM = new List<ForumModel>();
            Mapper.CreateMap<ForumB, ForumModel>();

            foreach (var forumb in list)
            {
                listforumM.Add(Mapper.Map<ForumB, ForumModel>(forumb));
            }
            return listforumM;
        }

        internal static CategorieModel ToModel(CategorieB categorieb)
        {
            Mapper.CreateMap<CategorieB, CategorieModel>();
            return Mapper.Map<CategorieB, CategorieModel>(categorieb);
        }
    }
}