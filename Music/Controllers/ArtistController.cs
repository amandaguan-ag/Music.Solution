using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;

namespace Music.Controllers
{
    public class ArtistController : Controller
    {
        public ActionResult Index()
        {
            List<Artist> allArtists = Artist.GetAll();
            return View(allArtists);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            // Add code to save artist to database here
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Artist artist = Artist.Find(id);
            return View(artist);
        }

        // Other action methods as required...
    }
}
