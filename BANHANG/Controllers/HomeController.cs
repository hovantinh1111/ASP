using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BANHANG.Conttext;
using BANHANG.Models;

namespace BANHANG.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBanHangEntities objwebsiteBanHangEntities = new WebsiteBanHangEntities();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();

            objHomeModel.ListCategorys = objwebsiteBanHangEntities.Categories.ToList();
            objHomeModel.Listproducts = objwebsiteBanHangEntities.Products.ToList();
            return View(objHomeModel);
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