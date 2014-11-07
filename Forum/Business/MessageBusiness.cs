using Forum.Business.Data;
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
        public void EditMessage(int id, long Utilisateur_id)
        {
            MessageDAL messagedal = new MessageDAL();
            MessageB messageb = ConvertBusiness.ToBusiness(messagedal.GetMessage(id));
            messageb.Utilisateur_id = Utilisateur_id;
            messagedal.EditMessage(ConvertBusiness.ToDAL(messageb));
        }

        public void DeleteMessage(int id)
        {
            MessageDAL message = new MessageDAL();
            message.DeleteMessage(id);
        }
    }
}