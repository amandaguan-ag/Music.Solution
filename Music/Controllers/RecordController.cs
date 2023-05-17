using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;
using System.Linq;

namespace Music.Controllers
{
  public class RecordsController : Controller
  {
    private readonly MusicContext _db;

    public RecordsController(MusicContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Record> model = _db.Records.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Record record)
    {
      _db.Records.Add(record);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Record thisRecord = _db.Records.FirstOrDefault(record => record.RecordId == id);
      return View(thisRecord);
    }
  }
}