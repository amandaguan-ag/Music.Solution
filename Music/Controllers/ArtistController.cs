// public class ArtistController : Controller
// {
//     private readonly ApplicationDbContext _db;

//     public ArtistController(ApplicationDbContext db)
//     {
//         _db = db;
//     }

//     // Implement actions like: Index, Details, Create, Edit, Delete etc.
//     public IActionResult Search(string name)
// {
//     var artists = _db.Artists
//         .Where(a => a.Name.ToLower().Contains(name.ToLower()))
//         .Include(a => a.Records)
//         .ToList();

//     return View(artists);  // You will need to create a corresponding view named "Search.cshtml"
// }

// }
