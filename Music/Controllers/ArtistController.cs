// using Microsoft.AspNetCore.Mvc;
// using Music.Models;
// using System.Collections.Generic;

// namespace Music.Controllers
// {
//     public class ArtistsController : Controller
//     {
//         [HttpGet("/artists")]
//         public ActionResult Index()
//         {
//             List<Artist> allArtists = Artist.GetAll();
//             return View(allArtists);
//         }

//         [HttpGet("/artists/new")]
//         public ActionResult New()
//         {
//             return View();
//         }

//         [HttpPost("/artists")]
//         public ActionResult Create(string artistName)
//         {
//             Artist newArtist = new Artist(artistName);
//             return RedirectToAction("Index");
//         }

//         [HttpGet("/artists/{id}")]
//         public ActionResult Show(int id)
//         {
//             Artist foundArtist = Artist.Find(id);
//             return View(foundArtist);
//         }
//     }
// }
