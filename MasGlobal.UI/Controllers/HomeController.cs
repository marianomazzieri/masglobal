using MasGlobal.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MasGlobal.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees(string Id)
        {
            string url = ConfigurationManager.AppSettings["ApiUrl"];
            int id;
            if (int.TryParse(Id, out id))
            {
                url += "/" + id.ToString();
            }

            HttpClient httpClient = new HttpClient();

            using (var response = httpClient.GetAsync(url).Result)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var employees = JsonConvert.DeserializeObject<List<Employee>>(data);
                TempData["Employees"] = employees;

                return RedirectToAction("Index");
            }
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