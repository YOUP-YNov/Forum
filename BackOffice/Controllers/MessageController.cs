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
        public ActionResult Details(int id)
        {
            try
            {
                MessageBusiness messageB = new MessageBusiness();
                MessageModel message = ConvertModel.ToModel(messageB.getMessage(id));
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
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(MessageModel message)
        {
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
        public ActionResult Edit(int id)
        {
            MessageBusiness messageB = new MessageBusiness();
            return View(messageB.getMessage(id));
        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MessageModel message)
        {
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
                return View();
            }
        }
    }
}
