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
            try
            {
                ForumBusiness forumB = new ForumBusiness();
                forumB.GetListForum();
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                ForumBusiness forumB = new ForumBusiness();
                ForumModel forumM = ConvertModel.ToModel(forumB.GetForum(id));
                return View(forumM);
            }
            catch
            {
                return View();
            }
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
            ForumBusiness forumB = new ForumBusiness();
            return View(forumB.GetForum(id));
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
