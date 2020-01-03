using RealSuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSuperHeros.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Hero
        public ActionResult Index()
        {
            var Heros = context.SuperHeros.ToList();
            return View(Heros);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            Hero hero = context.SuperHeros.Find(id);
            return View(hero);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            context.SuperHeros.Add(hero);
            context.SaveChanges();
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            var herro = context.SuperHeros.Find(id);
            return View(herro);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                context.Entry(hero).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            var herro = context.SuperHeros.Find(id);

            return View(herro);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                context.Entry(hero).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
