using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNETLearn1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            //1.Chuyển hướng qua Action khác cùng Controller
            //return RedirectToAction("DangNhap");

            //2.Chuyển hướng khác controller
            //return RedirectToAction("DanhSachTinTuc","TinTuc");

            //3.Chuyển hướng tới 1 URL
            //return Redirect("https://www.google.com/");

            //4.Chuyển hướng bằng RouteName (ở trong RouteConfig.cs)
            return RedirectToRoute("Default");
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
    }
}