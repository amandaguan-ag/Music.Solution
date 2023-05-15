// using Microsoft.AspNetCore.Mvc;
// using Music.Models;

// namespace Music.Controllers
// {
//     public class RecordsController : Controller
//     {
//         [HttpGet("/records/new")]
//         public ActionResult New()
//         {
//             return View();
//         }

//         [HttpPost("/records")]
//         public ActionResult Create(string recordTitle)
//         {
//             Record newRecord = new Record(recordTitle);
//             return RedirectToAction("Index");
//         }

//         [HttpGet("/records")]
//         public ActionResult Index()
//         {
//             List<Record> allRecords = Record.GetAll();
//             return View(allRecords);
//         }

//         [HttpGet("/records/{id}")]
//         public ActionResult Show(int id)
//         {
//             Record foundRecord = Record.Find(id);
//             return View(foundRecord);
//         }
//     }
// }
