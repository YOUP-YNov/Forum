using Forum.Business.Data;
using Forum.DAL;
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
    }
}