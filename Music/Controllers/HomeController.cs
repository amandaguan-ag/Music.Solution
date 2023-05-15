using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;

namespace Music.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Record> allRecords = Record.GetAll();
            return View(allRecords);
        }

        [HttpGet("/records/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/records")]
        public ActionResult Create(string recordTitle, string artistName)
        {
            Record newRecord = new Record(recordTitle, artistName);
            return RedirectToAction("Index");
        }

        [HttpGet("/records/{id}")]
        public ActionResult Show(int id)
        {
            Record foundRecord = Record.Find(id);
            return View(foundRecord);
        }
    }
}
