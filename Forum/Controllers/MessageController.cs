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
        public List<MessageModel> GetListMessage(int IDTopic)
        {
            return null;
        }
        /// <summary>
        /// Get an array of all user's messages
        /// </summary>
        /// <param name="IDUser">user id</param>
        /// <returns>Array</returns>
        public List<MessageModel> GetListMessageByUser(int IDUser)
        {
            return null;
        }
        /// <summary>
        /// Get a message information by id
        /// </summary>
        /// <returns>Array MessageModel</returns>
        public MessageModel GetMessage(int IDMessage)
        {
            return null;
        }
        /// <summary>
        /// Create an new message with his content
        /// </summary>
        /// <param name="Message">message content</param>
        public void CreateMessage(String Message)
        {
        }
        /// <summary>
        /// Edit message by message and the changed text
        /// </summary>
        /// <param name="IDMessage">message id</param>
        /// <param name="Message">message content</param>
        public void EditMessage(int IDMessage, String Message)
        {
        }
        /// <summary>
        /// Delete a message by id
        /// </summary>
        /// <param name="IDMessage">message id</param>
        public void DeleteMessage(int IDMessage)
        {
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
