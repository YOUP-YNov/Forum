using Forum.Business;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum.Controllers
{
    /// <summary>
    /// Available method for messages
    /// </summary>
    public class MessageController : ApiController
    {
        
        /// <summary>
        /// Get an array of all messages in a topic
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        /// <returns>Array ListMessageModel</returns>
        public List<MessageModel> GetListMessage()
        {
            MessageBusiness messageB = new MessageBusiness();
            return ConvertModel.ToModel(messageB.GetListMessage());
        }
        /// <summary>
        /// Get an array of all user's messages
        /// </summary>
        /// <param name="IDUser">user id</param>
        /// <returns>Array</returns>
        public List<MessageModel> GetListMessageByUser(int IDUser)
        {
            MessageBusiness messageb = new MessageBusiness();
            return ConvertModel.ToModel(messageb.GetListUserMessage(IDUser));
        }
        /// <summary>
        /// Get a message information by id
        /// </summary>
        /// <returns>Array MessageModel</returns>
        public MessageModel GetMessage(int IDMessage)
        {
            MessageBusiness messageb = new MessageBusiness();
            return ConvertModel.ToModel(messageb.getMessage(IDMessage));
        }
        /// <summary>
        /// Create an new message with his content
        /// </summary>
        /// <param name="Message">message content</param>
        public bool CreateMessage(MessageModel Message)
        {
            MessageBusiness messageb = new MessageBusiness();
            return messageb.CreateMessage(ConvertModel.ToBusiness(Message));
            
        }
        /// <summary>
        /// Edit message by message and the changed text
        /// </summary>
        /// <param name="IDMessage">message id</param>
        /// <param name="Message">message content</param>
        public void EditMessage(MessageModel mes)
        {

            MessageBusiness messageb = new MessageBusiness();
            messageb.EditMessage(ConvertModel.ToBusiness(mes));
        }
        /// <summary>
        /// Delete a message by id
        /// </summary>
        /// <param name="IDMessage">message id</param>
        public bool DeleteMessage(int IDMessage)
        {
            MessageBusiness messageb = new MessageBusiness();
            return messageb.DeleteMessage(IDMessage);

        }

        public List<MessageModel> GetListTopicMessage(int idTopic)
        {

            MessageBusiness messageb = new MessageBusiness();
            return ConvertModel.ToModel(messageb.GetListTopicMessage(idTopic));
        
        }

        /// <summary>
        /// Report a message by id
        /// </summary>
        /// <param name="IDMessage">message id</param>
        public void ReportMessage(int IDMessage)
        {

        }
    }
}
