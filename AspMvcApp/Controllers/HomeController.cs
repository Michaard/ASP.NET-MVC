using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvcApp.Models;

namespace AspMvcApp.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string xmlFileName)
        {
            if(String.IsNullOrEmpty(xmlFileName)){
                ViewData["Error"] = "You have to provide file name!";
                return View();
            }
            if (!(xmlFileName.EndsWith(".xml",true,null)))
                xmlFileName += ".xml";

            AspDatabase db = new AspDatabase();
            Root root = db.LoadDataFromXmlDatabase();

            if (root != null)
            {
                XmlGenerator generator = new XmlGenerator();

                string path = Server.MapPath("~/App_Data/"+xmlFileName).ToString();

                generator.Generate(path, root);

                ViewData["Message"] = "Download succesful! Xml saved to " + path;
            }
            else
            {
                ViewData["Error"] = "Download failed!";
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
