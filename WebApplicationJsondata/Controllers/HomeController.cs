using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplicationJsondata.Models;

namespace WebApplicationJsondata.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult JsonData()
        {
            var model = new JsondataModels();

            var filedatadetails = Directory.GetFileSystemEntries("c:/users/test/documents/visual studio 2015/Projects/WebApplicationJsondata/WebApplicationJsondata/JsonDataSet/sample-data.json");
            
           
            var filedata = File("~/JsonDataSet/sample-data.json","json");
            var data = filedata.ToString();

            var deselize = Json.deselize(data);
            var listmodel = new List<JsondataModels>();
            return View(listmodel);

            
        }
    }
}
