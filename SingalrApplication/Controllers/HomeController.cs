using SingalrApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SingalrApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SingalR()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingalR(Contact1 c)
        {
            pickpackDBEntities dc = new pickpackDBEntities();
            c.AddedOn = DateTime.Now;
            dc.Contact1.Add(c);
            dc.SaveChanges();
            return View();
        }
        public ActionResult Updates()
        {
            return View();
        }
        public ActionResult GetMessages()
        {
            MessagesRepository _messageRepository = new MessagesRepository();
            var model = _messageRepository.GetAllMessages();
            return PartialView("_MessagesList", model);

        }


        public JsonResult GetNotificationContacts()
        {
            var notificationRegisterTime = Session["LastUpdated"] != null ? Convert.ToDateTime(Session["LastUpdated"]) : DateTime.Now;
            NotificationComponent NC = new NotificationComponent();
            var list = NC.GetContacts(notificationRegisterTime);
            //update session here for get only new added contacts (notification)
            Session["LastUpdate"] = DateTime.Now;
            return new JsonResult { Data = list, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}