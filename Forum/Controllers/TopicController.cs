﻿using Forum.Business;
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
        /// <returns>Array ListTopicModel</returns>
        [HttpGet]
        [Route("api/Topics")]
        public List<TopicModel> GetListTopic()
        {
            TopicBusiness topic = new TopicBusiness();
            List<TopicModel> ob = ConvertModel.ToModel(topic.GetListTopic());
            return ob;
        }

        /// <summary>
        /// Get a topic information by id
        /// </summary>
        /// <param name="id">topic id</param>
        /// <returns>Array TopicModel</returns>
        [HttpGet]
        [Route("api/Topic/{id}")]
        public TopicModel GetTopic(int id)
        {
            TopicBusiness topic = new TopicBusiness();
            return ConvertModel.ToModel(topic.GetTopic(id));
        }

        /// <summary>
        /// Get a topic information by event id
        /// </summary>
        /// <param name="IDEvent">event id</param>
        /// <returns>Array TopicModel</returns>
        [HttpGet]
        [Route("api/TopicEvent/{IDEvent}")]
        public TopicModel GetTopicByEvent(int IDEvent)
        {
            TopicBusiness topic = new TopicBusiness();
            return ConvertModel.ToModel(topic.GetTopicByEvent(IDEvent));
        }

        /// <summary>
        /// Get a topic information by Category id
        /// </summary>
        /// <param name="IDEvent">event id</param>
        /// <returns>Array TopicModel</returns>
        [HttpGet]
        [Route("api/TopicCategory/{IDCategory}")]
        public List<TopicModel> GetTopicByEvent(int IDCategory)
        {
            TopicBusiness topic = new TopicBusiness();
            return ConvertModel.ToModel(topic.GetTopicByCategory(IDCategory));
        }

        /// <summary>
        /// Create a topic with category id, a name and the content
        /// </summary>
        /// <param name="topic">TopicModel</param>
        [HttpPost]
        [Route("api/Topic")]
        public bool CreateTopic(TopicModel Top)
        {
            /*TopicModel NewTopic = new TopicModel();
            NewTopic.Nom = Name;
            NewTopic.Url = string.Empty;
            TopicBusiness Top = new TopicBusiness();
            Top.CreateForum(ConvertModel.ToBusiness(NewTopic));*/
            return true;
        }

        /// <summary>
        /// Edit a topic by id and the changed text
        /// </summary>
        /// <param name="topic">TopicModel</param>
        [HttpPost]
        [Route("api/Topic/{id}")]
        public bool EditTopic(TopicModel Top)
        {
            TopicBusiness TopicM = new TopicBusiness();
            return TopicM.EditTopic(ConvertModel.ToBusiness(Top));          
        }

        /// <summary>
        /// Delete topic by id
        /// </summary>
        /// <param name="IDTopic">topic id</param>
        [HttpDelete]
        [Route("api/Topic/{IDTopic}")]
        public bool DeleteTopic(int IDTopic)
        {
            TopicBusiness topicB = new TopicBusiness();
            return topicB.DeleteTopic(IDTopic);
        }
    }
}