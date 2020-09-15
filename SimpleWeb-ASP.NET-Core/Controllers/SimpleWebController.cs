using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using SimpleWeb_ASP.NET_Core.Data;
using SimpleWeb_ASP.NET_Core.Models;


namespace SimpleWeb_ASP.NET_Core.Controllers
{
    public class SimpleWebController : Controller
    {
        private SimpleWebRepository _simpleWebRepository = null;

        public SimpleWebController()
        {
            _simpleWebRepository = new SimpleWebRepository();
        }

        public ActionResult Index()
        {
            List<Webs> simpleWeb = _simpleWebRepository.GetSimpleWeb();

            // Calculate the total activity minutes
            double totalActivity = simpleWeb
                .Where(e => e.Exclude == false) // Only include the NON Excluded entries
                .Sum(e => e.Duration);

            int numberOfSimpleWeb = simpleWeb
                .Select(e => e.Date)
                .Distinct()
                .Count();

            ViewBag.TotalActivity = totalActivity;
            ViewBag.AverageDailyActivites = (totalActivity / (double)numberOfSimpleWeb);

            return View(simpleWeb);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new StatusCodeResult(400);
            }
            return View();
        }
    }
}
