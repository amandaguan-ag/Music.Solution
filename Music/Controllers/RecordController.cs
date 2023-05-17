using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;

namespace Music.Controllers
{
    public class RecordsController : Controller
    {
        [HttpGet("/artists/{artistId}/records/new")]
        public ActionResult New(int artistId)
        {
            Artist artist = Artist.Find(artistId);
            if (artist == null)
            {
                // Handle the case where no artist was found.
                // You could return a different view, or redirect to a different action.
                return NotFound(); // Returns a 404 Not Found response.
            }
            return View(artist);
        }

        [HttpGet("/artists/{artistId}/records/{recordId}")]
        public ActionResult Show(int artistId, int recordId)
        {
            Record record = Record.Find(recordId);
            Artist artist = Artist.Find(artistId);
            if (record == null || artist == null)
            {
                // Handle the case where no record or artist was found.
                return NotFound();
            }
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("artist", artist);
            model.Add("record", record);
            return View(model);
        }
    }
}
