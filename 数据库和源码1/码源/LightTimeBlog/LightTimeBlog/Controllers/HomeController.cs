using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LightTimeBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 发布博客
        /// </summary>
        /// <returns></returns>
        public ActionResult Postblog()
        {
            return View();
        }
        public ActionResult Postalbum()
        {
            return View();
        }
        public ActionResult CheckPhoto()
        {
            return View();
        }
        /// <summary>
        /// 相册广场
        /// </summary>
        public ActionResult Asquare() 
        {
            return View();
        }
        /// <summary>
        /// 照片详情，评论
        /// </summary>
        /// <returns></returns>
        public ActionResult Acomments()
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
    }
}