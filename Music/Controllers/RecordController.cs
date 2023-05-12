using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;

namespace Music.Controllers
{
    public class RecordController : Controller
    {
        [HttpGet("/records")]
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
        public ActionResult Create(string title, int artistId)
        {
            Artist artist = Artist.Find(artistId);
            Record newRecord = new Record(title, artist);
            return RedirectToAction("Index");
        }

        [HttpGet("/records/{id}")]
        public ActionResult Show(int id)
        {
            Record record = Record.Find(id);
            return View(record);
        }
    }
}
