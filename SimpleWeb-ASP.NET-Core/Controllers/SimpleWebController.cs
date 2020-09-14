using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWeb_ASP.NET_Core.Data;
using SimpleWeb_ASP.NET_Core.Models;
using System.Net;

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
            List<Task> tasks = _simpleWebRepository.GetTasks();

            // Calculate the total activity minutes
            double totalActivity = tasks
                .Where(e => e.Exclude == false) // Only include the NON Excluded entries
                .Sum(e => e.Duration);

            int numberOfTasks = tasks
                .Select(e => e.Date)
                .Distinct()
                .Count();

            ViewBag.TotalActivity = totalActivity;
            ViewBag.AverageDailyActivity = (totalActivity / (double)numberOfTasks);

            return View(tasks);
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
