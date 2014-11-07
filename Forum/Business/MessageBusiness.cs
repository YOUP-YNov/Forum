﻿using Forum.Business.Data;
using Forum.DAL;
using Forum.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Business
{
    public class MessageBusiness
    {
        public MessageB getMessage(int id)
        {
            MessageDAL message = new MessageDAL();
            return ConvertBusiness.ToBusiness(message.GetMessage(id));
        }
        public void EditMessage(MessageB mes)
        {
            MessageDAL messagedal = new MessageDAL();
            messagedal.EditMessage(ConvertBusiness.ToDAL(mes));
        }

        //permet de creer un message 
        public void CreateMessage(MessageB mes)
        {
            MessageDAL message = new MessageDAL();
            message.CreateMessage(ConvertBusiness.ToDAL(mes));
        }

        //récupère une liste de topic
        public List<MessageB> GetListTopicMessage(int idTopic)
        {
            MessageDAL message = new MessageDAL();
            return ConvertBusiness.ToBusiness(message.GetListTopicMessage(idTopic));

            
        }

        public List<MessageB> GetListUserMessage(int idUser)
        {
            MessageDAL message = new MessageDAL();
            return ConvertBusiness.ToBusiness(message.GetListUserMessage(idUser));
        }

        public List<MessageB> GetListMessage()
        {
            MessageDAL message = new MessageDAL();
            return ConvertBusiness.ToBusiness(message.GetListMessage());
        }

        public void DeleteMessage(int id)
        {
            MessageDAL message = new MessageDAL();
            message.DeleteMessage(id);
        }
    }
}