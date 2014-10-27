using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum.Controllers
{
    /// <summary>
    /// Available method
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get an array of all forum informations
        /// </summary>
        /// <returns>Array</returns>
        public ListForumModel GetListForum (){
            return null;
        }

        /// <summary>
        /// Get a forum information by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>ForumModel ForumModel</returns>
        public ForumModel GetForum(int IDForum)
        {
            return null;
        }
        /// <summary>
        /// Create a forum with his name
        /// </summary>
        /// <param name="Name">Name of the forum</param>
        public void CreateForum (string Name){
        }
        /// <summary>
        /// Edit a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public void EditForum (int IDForum){
        }
        /// <summary>
        /// Delete a forum by id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        public void DeleteForum (int IDForum){
        }


        /// <summary>
        /// Get an array of all category informations
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <returns>Array ListCategoryModel</returns>
        public ListCategoryModel GetListCategory(int IDForum)
        {
            return null;
        }
        /// <summary>
        /// Create a forum with his name and the forum id
        /// </summary>
        /// <param name="IDForum">forum id</param>
        /// <param name="Name">forum name</param>
        public void CreateCategory(int IDForum, string Name)
        {
        }
        /// <summary>
        /// Edit a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        public void EditCategory(int IDCategory)
        {
        }
        /// <summary>
        /// Delete a category by id
        /// </summary>
        /// <param name="IDCategory">category id</param>
        public void DeleteCategory(int IDCategory)
        {
        }


        /// <summary>
        /// Get an array of all topic informations
        /// </summary>
        /// <param name="IDCategory">category id</param>
        /// <returns>Array ListTopicModel</returns>
        public ListTopicModel GetListTopic(int IDCategory)
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



        /// <summary>
        /// Get an array of all messages in a topic
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        /// <returns>Array ListMessageModel</returns>
        public ListMessageModel GetListMessage(int IDTopic)
        {
            return null;
        }
        /// <summary>
        /// Get an array of all user's messages
        /// </summary>
        /// <param name="IDUser">user id</param>
        /// <returns>Array</returns>
        public ListMessageModel GetListMessageByUser(int IDUser)
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
