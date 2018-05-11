using MessageWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageWebApp.Controllers
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
    }
}