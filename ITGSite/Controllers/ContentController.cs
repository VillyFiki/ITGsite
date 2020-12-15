using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITGSite.Models;
using ITGSite.Models.Manuals;
using Microsoft.AspNetCore.Http;

namespace ITGSite.Controllers
{
    public class ContentController : Controller
    {
        private ManualContext db;
        public ContentController(ManualContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manuals(int id)
        {
            var a = db.Manuals.SingleOrDefault(x => x.Id == id);

            if (a != null)
            {
                return View("Manuals", a);
            }
            return View("Manuals");
        }
        public ContentResult SendRequest(int id) 
        {
            string response = "";
            switch (id)
            {
                case 1:
                    response = RequestModel.procedures().Result;
                    break;
                case 2:
                    response = RequestModel.company_list().Result;
                    break;
                case 3:
                    response = RequestModel.company().Result;
                    break;
                case 4:
                    response = RequestModel.protocols_list().Result;
                    break;
                case 5:
                    response = RequestModel.protocols().Result;
                    break;
                default:
                    response = "error";
                    break;
            }
            return new ContentResult
            {
                Content = response,
                ContentType = "application/xml",
                StatusCode = 200
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
