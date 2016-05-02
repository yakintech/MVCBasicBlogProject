using MVCBasicBlog.Models.ORM.Entity;
using MVCBasicBlog.Models.VM;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicBlog.Areas.Admin.Controllers
{
    public class ContactMessagesController : BaseAdminController
    {
        
        public ActionResult Index(int? id)
        {
            int pagenumber = id ?? 1;
            int pagesize = 10;
            List<Contact> contactlist = db.Contacts.Where(x => x.IsDeleted == false).ToList(); 
            IPagedList<ContactVM> model = contactlist.Select(x => new ContactVM()
            {
                EMail = x.EMail,
                Message = x.Message,
                Name = x.Name,
                Phone = x.Phone,
                ID = x.ID
            }).ToPagedList(pagenumber,pagesize);

            return View(model);
        }

        public JsonResult DeleteContact(int id)
        {
            Contact contact = db.Contacts.FirstOrDefault(x => x.ID == id);
            if (contact != null)
            {
                contact.IsDeleted = true;
                db.SaveChanges();
            }

            return Json("");
        }

        public ActionResult DeleteContact2(int id)
        {
            Contact contact = db.Contacts.FirstOrDefault(x => x.ID == id);
            if (contact != null)
            {
                contact.IsDeleted = true;
                db.SaveChanges();
            }

            return RedirectToAction("Index", "ContactMessages");


        }

        public JsonResult ViewContact(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            Contact contact = db.Contacts.FirstOrDefault(x => x.ID == id);
            return Json(contact, JsonRequestBehavior.AllowGet);

        }

    }
}