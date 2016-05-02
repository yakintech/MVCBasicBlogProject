using MVCBasicBlog.Models.ORM.Context;
using MVCBasicBlog.Models.ORM.Entity;
using MVCBasicBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Controllers
{
    public class HomeController : BaseUIController
    {

       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult UserContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserContact(ContactVM model)
        {

            //Hata mesajları yazılır. Viewbag işlem durumları
            if (ModelState.IsValid)
            {
                for (int i = 0; i < 100; i++)
                {
                    Contact contact = new Contact();
                    contact.EMail = model.EMail;
                    contact.Phone = model.Phone;
                    contact.Message = model.Message;
                    contact.Name = model.Name;

                    db.Contacts.Add(contact);
                    db.SaveChanges();
                }

                return View();
            }
            else
            {
                return View();
            }
           
        }
    }
}