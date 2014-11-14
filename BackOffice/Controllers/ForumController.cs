using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackOffice.Models;
using Forum.Business;

namespace BackOffice.Controllers
{
    public class ForumController : Controller
    {
        // GET: Forum
        public ActionResult Index()
        {
            ForumBusiness forumB = new ForumBusiness();
            forumB.GetListForum();
            return View();
        }

        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            ForumBusiness forum = new ForumBusiness();
            ForumModel forumM = ConvertModel.ToModel(forum.GetForum(id));
            return View(forumM);
        }

        // GET: Forum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        [HttpPost]
        public ActionResult Create(ForumModel forum)
        {
            try
            {
                // TODO: Add insert logic here
                ForumBusiness forumB = new ForumBusiness();
                forumB.CreateForum(ConvertModel.ToBusiness(forum));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Edit/5
        public ActionResult Edit(int id)
        {
            ForumBusiness forum = new ForumBusiness();
            return View(forum.GetForum(id));
        }

        // POST: Forum/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ForumModel forum)
        {
            try
            {
                // TODO: Add update logic here
                ForumBusiness forumB = new ForumBusiness();
                forumB.EditForum(ConvertModel.ToBusiness(forum));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Forum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ForumModel forum)
        {
            try
            {
                ForumBusiness forumB = new ForumBusiness();
                forumB.DeleteForum(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
