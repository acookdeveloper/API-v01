using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using API_01.Models;

namespace API_01.Controllers
{
    public class User_AuthController : Controller
    {
        private API01Entities db = new API01Entities();

        // GET: User_Auth
        public ActionResult Index()
        {
            return View(db.User_Auth.ToList());
        }

        // GET: User_Auth/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Auth user_Auth = db.User_Auth.Find(id);
            if (user_Auth == null)
            {
                return HttpNotFound();
            }
            return View(user_Auth);
        }

        // GET: User_Auth/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_Auth/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,PasswordHash,Salt,Name,Position,AccessLevel,UserGUID")] User_Auth user_Auth)
        {
            if (ModelState.IsValid)
            {
                db.User_Auth.Add(user_Auth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Auth);
        }

        // GET: User_Auth/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Auth user_Auth = db.User_Auth.Find(id);
            if (user_Auth == null)
            {
                return HttpNotFound();
            }
            return View(user_Auth);
        }

        // POST: User_Auth/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,PasswordHash,Salt,Name,Position,AccessLevel,UserGUID")] User_Auth user_Auth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Auth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_Auth);
        }

        // GET: User_Auth/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Auth user_Auth = db.User_Auth.Find(id);
            if (user_Auth == null)
            {
                return HttpNotFound();
            }
            return View(user_Auth);
        }

        // POST: User_Auth/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User_Auth user_Auth = db.User_Auth.Find(id);
            db.User_Auth.Remove(user_Auth);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
