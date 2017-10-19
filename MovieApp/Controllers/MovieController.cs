using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
  public class MovieController : Controller
  {
    private static List<string> db = new List<string>
    {
      "Iron Man",
      "Justice League"
    };

    // GET: Movie
    public ViewResult Index(string search)
    {
      var movies = (search == null)
        ? db.ToArray()
        : db.Where(name => name.ToLower().Contains(search.Trim().ToLower()))
        .ToArray();

      var viewModel = new MovieSearchViewModel
      {
        Search = search,
        Movies = movies
      };
      return View(viewModel);
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public ActionResult Create(string movie)
    {
      db.Add(movie);
      return RedirectToAction("Index");
    }
  }
}