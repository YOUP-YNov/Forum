using Forum.DAL;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Forum.DAL.Data;
using Forum.Business.Data;

namespace Forum.Business
{
    public class ForumBusiness
    {

        public ForumB getForum(int id) {

            ForumDAL forum = new ForumDAL();
            return  ConvertBusiness.ToBusiness(forum.GetForum(id));
        }
    }
}