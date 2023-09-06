using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example01.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa

        // HAYIR NET CORE DA DA AYNIDIR.

        // OOP ActionResult ??????  Ben bir tip oluşturayım bu tip kapsayıcı olsun,  Json

        // action metoddur.
        //public ActionResult Index()
        //{
        //    return View();
        //    //return View();
        //}

        public ActionResult Sevgul()
        {
            return View("Cemil");
        }

        public ActionResult Yavuz()
        {
            //return RedirectToAction("");
            return View();
        }

        public ActionResult Berkay()
        {
            return View();
        }

        public ActionResult Ozan()
        {
            return View();
        }


        // yavuzselimkahraman.com/home/hakan?sevgul=3&yavuz=2
        // Kabul eder misin ? 
        // Model Binding =>


        // REQUEST
        // yavuzselimkahraman.com/Anasayfa/Index?id =3

        // ROUTE(PARAMS), QUERY ?name = 3 & yavuz=5 


        // Route  yavuzselimkahraman.com/Anasayfa/Index/Mavi-Renkli-Corap


        /* void Main(string[] args) */
        public ActionResult Hakan(int id, string name)
        {

           // Request ile veri taşıyoruz route veya query
           // action dan viewlara

            // AspNetCulture.  Localization & Globalization cookiden sonra göreceğiz.
            //var id = HttpContext.Request.RequestContext.RouteData.Values["id"];
            
            // Model Binding ??? HER YERDE .... 
            //textbox => text her zaman string 
            //var yavuz = httpcontext.request.querystring["yavuz"];
            //var sevgul = httpcontext.request.querystring["sevgul"];
            return View();
        }
    }
}