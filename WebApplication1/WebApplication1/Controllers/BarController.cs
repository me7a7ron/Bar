using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BarController : Controller
    {
        // GET: Bar
        public ActionResult Index()
        {
            return View(piwkowanie);
        }      
        public Iimpreza piwkowanie;

        public BarController()
        {          
            piwkowanie = Piwkowanie.PiwkowanieInstancja;
        }
        [HttpGet]
        public JsonResult Wypij(string nazwa,int ilosc)
        {
            string[] info = new string[2];
            info[0] = piwkowanie.podajAlko(nazwa, ilosc).ToString();          
            info[1] = "Na Pochybel skurwysynom";//toast;  
            return Json(info,JsonRequestBehavior.AllowGet);
        }
    }
}