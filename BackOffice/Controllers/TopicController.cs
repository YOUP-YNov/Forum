using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Business;
using BackOffice.Models;

namespace BackOffice.Controllers
{
    public class TopicController : Controller
    {
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
        public ActionResult Details(int id)
        {
            TopicBusiness topicB = new TopicBusiness();
            TopicModel topic = ConvertModel.ToModel(topicB.GetTopic(id));
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
        public ActionResult Create(TopicModel topic, int CategoryChoice)
        {
            topic.Sujet_id = CategoryChoice;
            try
            {
                // TODO: Add insert logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.CreateTopic(ConvertModel.ToBusiness(topic));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int id)
        {
            CategorieBusiness categorie = new CategorieBusiness();
            ViewBag.CategoryChoice = new SelectList(categorie.GetListCategorie(), "Sujet_id", "Nom");
            TopicBusiness topicB = new TopicBusiness();
            return View(topicB.GetTopic(id));
        }

        // POST: Topic/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TopicModel topic, int CategoryChoice)
        {
            topic.Sujet_id = CategoryChoice;
            try
            {
                // TODO: Add update logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.EditTopic(ConvertModel.ToBusiness(topic));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Topic/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TopicModel topic)
        {
            try
            {
                // TODO: Add delete logic here

                TopicBusiness topicB = new TopicBusiness();
                topicB.DeleteTopic(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
