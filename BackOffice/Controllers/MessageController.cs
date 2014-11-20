using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Business;
using BackOffice.Models;

namespace BackOffice.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            try
            {
                MessageBusiness messageB = new MessageBusiness();
                List<MessageModel> list = ConvertModel.ToModel(messageB.GetListMessage());
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult IndexByTopic(int idTopic)
        {
            try
            {
                MessageBusiness messageB = new MessageBusiness();
                List<MessageModel> list = ConvertModel.ToModel(messageB.GetListTopicMessage(idTopic));
                return View("Index", list);
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Message/Details/5
        public ActionResult Details(int idMessage)
        {
            try
            {
                MessageBusiness messageB = new MessageBusiness();
                MessageModel message = ConvertModel.ToModel(messageB.getMessage(idMessage));
                return View(message);
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            TopicBusiness topicB = new TopicBusiness();
            List<TopicModel> list = ConvertModel.ToModel(topicB.GetListTopic());
            ViewBag.TopicChoice = new SelectList(list, "Topic_id", "Nom");
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(MessageModel message, DateTime DateCrea)
        {
            message.DatePoste = DateCrea;
            try
            {
                // TODO: Add insert logic here

                MessageBusiness messageB = new MessageBusiness();
                messageB.CreateMessage(ConvertModel.ToBusiness(message));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int idMessage)
        {
            MessageBusiness messageB = new MessageBusiness();
            return View(ConvertModel.ToModel(messageB.getMessage(idMessage)));
        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(MessageModel message, DateTime DateCrea)
        {
            message.DatePoste = DateCrea;
            try
            {
                // TODO: Add update logic here

                MessageBusiness messageB = new MessageBusiness();
                messageB.EditMessage(ConvertModel.ToBusiness(message));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Message/Delete/5
        public ActionResult Delete(int idMessage)
        {
            try
            {
                // TODO: Add delete logic here

                MessageBusiness messageB = new MessageBusiness();
                messageB.DeleteMessage(idMessage);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
