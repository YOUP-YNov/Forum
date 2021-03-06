﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Business;
using BackOffice.Models;
using RestSharp;
using System.Configuration;

namespace BackOffice.Controllers
{
    public class TopicController : Controller
    {
        public List<UserSmallModel> ListUser;
        public TopicController()
        {
            ListUser = GetUsers();
        }
        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(ConfigurationManager.AppSettings["AdresseModuleProfile"]);
            var response = client.Execute<T>(request);
            return response.Data;
        }

        public List<UserSmallModel> GetUsers()
        {
            var request = new RestRequest("api/UserSmall", Method.GET);
            var result = Execute<List<UserSmallModel>>(request);

            return result;
        }
        // GET: Topic
        public ActionResult Index()
        {
            try
            {
                TopicBusiness topicB = new TopicBusiness();
                List<TopicModel> list = ConvertModel.ToModel(topicB.GetListTopic());
                return View(list);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult IndexByCategory(int idCategorie)
        {
            try
            {
                TopicBusiness topicB = new TopicBusiness();
                List<TopicModel> list = ConvertModel.ToModel(topicB.GetTopicByCategory(idCategorie));
                return View("Index",list);
            }
            catch
            {
                return View("Index");
            }
        }
        // GET: Topic/Details/5
        public ActionResult Details(int idTopic)
        {
            TopicBusiness topicB = new TopicBusiness();
            TopicModel topic = ConvertModel.ToModel(topicB.GetTopic(idTopic));
            return View(topic);
        }

        // GET: Topic/Create
        public ActionResult Create()
        {
            CategorieBusiness categorie = new CategorieBusiness();
            ViewBag.CategoryChoice = new SelectList(categorie.GetListCategorie(), "Sujet_id", "Nom");
            return View();
        }

        // POST: Topic/Create
        [HttpPost]
        public ActionResult Create(TopicModel topic, int CategoryChoice, DateTime DateCrea)
        {
            topic.Utilisateur_id = ListUser.Where(p => p.Pseudo == "ForumAdmin").FirstOrDefault().Utilisateur_Id;
            topic.Sujet_id = CategoryChoice;
            topic.DateCreation = DateCrea;
            try
            {
                // TODO: Add insert logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.CreateTopic(ConvertModel.ToBusiness(topic));
                return RedirectToAction("Index");
            }
            catch
            {
                CategorieBusiness categorie = new CategorieBusiness();
                ViewBag.CategoryChoice = new SelectList(categorie.GetListCategorie(), "Sujet_id", "Nom");
                return View();
            }
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int idTopic)
        {
            CategorieBusiness categorie = new CategorieBusiness();
            ViewBag.CategoryChoice = new SelectList(categorie.GetListCategorie(), "Sujet_id", "Nom");
            TopicBusiness topicB = new TopicBusiness();
            return View(ConvertModel.ToModel(topicB.GetTopic(idTopic)));
        }

        // POST: Topic/Edit/5
        [HttpPost]
        public ActionResult Edit(TopicModel topic, DateTime DateCrea)
        {
            topic.DateCreation = DateCrea;
            try
            {
                // TODO: Add update logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.EditTopic(ConvertModel.ToBusiness(topic));
                return RedirectToAction("Index");
            }
            catch
            {
                CategorieBusiness categorie = new CategorieBusiness();
                ViewBag.CategoryChoice = new SelectList(categorie.GetListCategorie(), "Sujet_id", "Nom");
                return View();
            }
        }


        // POST: Topic/Delete/5
        public ActionResult Delete(int idTopic)
        {
            try
            {
                // TODO: Add delete logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.DeleteTopic(idTopic);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}