using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ConvertModel
    {


        internal static List<MessageModel> ToModel(List<Business.Data.MessageB> list)
        {
            List<MessageModel> listmessage = new List<MessageModel>();
            Mapper.CreateMap<Business.Data.MessageB, MessageModel>();

            foreach (var messagemodel in list)
            {
                listmessage.Add(Mapper.Map<Business.Data.MessageB, MessageModel>(messagemodel));
            }
            return listmessage ;
        }

        internal static MessageModel ToModel(Business.Data.MessageB messageB)
        {
            Mapper.CreateMap<Business.Data.MessageB, MessageModel>();
            return Mapper.Map<Business.Data.MessageB, MessageModel>(messageB);
        }



        internal static Business.Data.MessageB ToBusiness(MessageModel Message)
        {
            Mapper.CreateMap<MessageModel, Business.Data.MessageB>();
            return Mapper.Map<MessageModel, Business.Data.MessageB>(Message);
        }
    }
}