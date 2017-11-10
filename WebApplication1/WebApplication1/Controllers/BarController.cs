using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
        [HttpPost]
        public JsonResult Wypij(String testy)
        {
            decimal Kasa = 0;
            IEnumerable<Zamowienie> zamowienie = JsonConvert.DeserializeObject<IEnumerable<Zamowienie>>(testy);          
            string[] info = new string[2];
            foreach (var item in zamowienie)
            {
                Kasa = Kasa + piwkowanie.podajAlko(item.Nazwa, int.Parse(item.Sztuk));
            }
            info[0] = Kasa.ToString();          
            info[1] = "Na Pochybel skurwysynom";//toast;  
            return Json(info,JsonRequestBehavior.AllowGet);
        }
    }
}