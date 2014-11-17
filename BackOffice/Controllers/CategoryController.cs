﻿using BackOffice.Models;
using Forum.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackOffice.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            try
            {
                CategorieBusiness cat = new CategorieBusiness();
                List<CategorieModel> list = ConvertModel.ToModel(cat.GetListCategorie());
                return View(list);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult IndexByForum(int idForum)
        {
            try
            {
                CategorieBusiness cat = new CategorieBusiness();
                List<CategorieModel> list = ConvertModel.ToModel(cat.GetListCategorieForum(idForum));
                return View("Index", list);
            }
            catch
            {
                return View();
            }
        }
        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                CategorieBusiness cat = new CategorieBusiness();
                CategorieModel category = ConvertModel.ToModel(cat.getCategorie(id));
                return View(category);
            }
            catch
            {
                return (null);
            }
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            try
            {
                ForumBusiness forumB = new ForumBusiness();
                List<ForumModel> list = ConvertModel.ToModel(forumB.GetListForum());
                ViewBag.ForumChoice = new SelectList(list, "Forum_id", "Nom");
            }
            catch
            {
                ViewBag.ForumChoice = new SelectList(null);
            }
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategorieModel cat, int ForumChoice)
        {
            cat.Forum_id = ForumChoice;
            try
            {
                CategorieBusiness catB = new CategorieBusiness();
                catB.CreateCategorie(ConvertModel.ToBusiness(cat));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                CategorieBusiness cat = new CategorieBusiness();
                ForumBusiness forumB = new ForumBusiness();
                List<ForumModel> list = ConvertModel.ToModel(forumB.GetListForum());
                ViewBag.ForumChoice = new SelectList(list, "Forum_id", "Nom");
                return View(cat.getCategorie(id));
            }
            catch
            {
                ViewBag.ForumChoice = new SelectList(null);
                return View();
            }
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategorieModel cat, int ForumChoice)
        {
            cat.Forum_id = ForumChoice;
            try
            {
                CategorieBusiness catB = new CategorieBusiness();
                catB.EditCategorie(ConvertModel.ToBusiness(cat));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategorieModel cat)
        {
            try
            {
                CategorieBusiness catB = new CategorieBusiness();
                catB.DeleteCategorie(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
