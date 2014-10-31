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
    /// Available method for topics
    /// </summary>
    public class TopicController : ApiController
    {
        /// <summary>
        /// Get an array of all topic informations
        /// </summary>
        /// <param name="IDCategory">category id</param>
        /// <returns>Array ListTopicModel</returns>
        public List<TopicModel> GetListTopic(int IDCategory)
        {
            return null;
        }
        /// <summary>
        /// Get a topic information by id
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        /// <returns>Array TopicModel</returns>
        public TopicModel GetTopic(int IDTopic)
        {
            return null;
        }
        /// <summary>
        /// Get a topic information by event id
        /// </summary>
        /// <param name="IDEvent">event id</param>
        /// <returns>Array TopicModel</returns>
        public TopicModel GetTopicByEvent(int IDEvent)
        {
            return null;
        }
        /// <summary>
        /// Create a topic with category id, a name and the content
        /// </summary>
        /// <param name="IDcategory">category id</param>
        /// <param name="Name">name</param>
        /// <param name="Contenu">content</param>
        public void CreateTopic(int IDcategory, string Name, string Contenu)
        {
        }
        /// <summary>
        /// Edit a topic by id and the changed text
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        /// <param name="Titre">title</param>
        public void EditTopic(int IDTopic, string Titre)
        {
        }
        /// <summary>
        /// Delete topic by id
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        public void DeleteTopic(int IDTopic)
        {
        }
    }
}
