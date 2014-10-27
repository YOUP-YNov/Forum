using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum.Controllers
{
    /// <summary>
    /// Method exposed
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get all forum
        /// </summary>
        /// <returns></returns>
        public ListForumModel GetListForum (){
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>ForumModel ForumModel</returns>
        public ForumModel GetForum (){
            return null;
        }
        public void CreateForum (string Name){
        }
        public void EditForum ( int IDForum){
        }
        public void DeleteForum ( int IDForum){
        }


        public ListCategoryModel GetListCategory(int IDForum)
        {
            return null;
        }
        public void CreateCategory(int IDForum, string Name)
        {
        }
        public void EditCategory(int IDCategory)
        {
        }
        public void DeleteCategory(int IDCategory)
        {
        }


        public ListTopicModel GetListTopic(int IDCategory)
        {
            return null;
        }
        public TopicModel GetTopic(int IDTopic)
        {
            return null;
        }
        public TopicModel GetTopicByEvent(int IDEvent)
        {
            return null;
        }
        public void CreateTopic(int IDcategory, string Name, string Contenu)
        {
        }
        public void EditTopic(int IDTopic, string Titre)
        {
        }
        public void DeleteTopic(int IDTopic)
        {
        }



        public ListMessageModel GetListMessage(int IDTopic)
        {
            return null;
        }
        public MessageModel GetMessage(int IDMessage)
        {
            return null;
        }
        public ListMessageModel GetListMessageByUser(int IDUser)
        {
            return null;
        }
        public void CreateMessage(String Message)
        {
        }
        public void EditMessage(int IDMessage, String Message)
        {
        }
        public void DeleteMessage(int IDMessage)
        {
        }


        public void ReportMessage(int IDMessage)
        {
        }







        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
