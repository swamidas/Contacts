using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            List<Contact> model = (List<Contact>) HttpContext.Application["Contacts"];
            ViewBag.Message = "Set from Index action - Count:" + model.Count;
            return View(model);
        }

        // GET: Contacts/Details/5  
        public ActionResult Details(int id)
        {
            Contact model = GetModel(id);
            return View(model);
        }

        private Contact GetModel(int? id = null)
        {
            var list = (List<Contact>)HttpContext.Application["Contacts"];
            ViewBag.List = list;
            var model = (id.HasValue) ? list.First(x => x.Id == id) : new Contact();
            return model;
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            Contact model = GetModel();
            return View("Edit", model); //reuse Edit view out of laziness
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var list = (List<Contact>)HttpContext.Application["Contacts"];
                    list.Add(contact);
                    HttpContext.Application["Contacts"] = list;
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            Contact model = GetModel(id);
            return View(model);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var list = (List<Contact>)HttpContext.Application["Contacts"];
                    list.Remove(list.First(x => x.Id == contact.Id));
                    list.Add(contact);
                    HttpContext.Application["Contacts"] = list;
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Delete/5
        public ActionResult DeleteConfirm(int id)
        {
            return View();
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Count()
        {
            ViewBag.Message = ViewBag.Message == null ? "Set in Index action not carried onto Count action" : ViewBag.Message;
            return PartialView();
        }
    }
}
