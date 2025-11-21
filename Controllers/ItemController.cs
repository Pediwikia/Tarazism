using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;
using System.Web;

namespace Tarazism.Controllers
{
    public class ItemController : Controller
    {
        // In real app, fetch from DB
        public IActionResult Details(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) return NotFound();

            var model = new CategoryItem
            {
                Title = title,
                ImageUrl = "/img/gallery/1.jpg",
                Description = "Detailed description for " + title,
                Category = "Mixed",
                Tags = new List<string> { "Featured" },
                Rating = 4.5f,
            };

            // also fetch reviews for this title
            var reviews = ReviewRepository.ForItem(title).ToList();

            ViewData["Reviews"] = reviews;
            return View(model);
        }

        // Moved matrix and ViewBag assignment into an action method
        public IActionResult Matrix()
        {
            var matrix = new MediaMatrix
            {
                Title = "Tarazism Media Matrix",
                Items = new()
                {
                    new MatrixItem {
                        Name = "Mushishi",
                        Category = "Anime",
                        ImageUrl = "/img/matrix/mushishi.jpg",
                        Atmosphere = 5,
                        Lore = 4,
                        Depth = 5,
                        Balance = 5
                    },
                    new MatrixItem {
                        Name = "The Witcher 3",
                        Category = "Game",
                        ImageUrl = "/img/matrix/witcher.jpg",
                        Atmosphere = 5,
                        Lore = 5,
                        Depth = 4,
                        Balance = 5
                    },
                    new MatrixItem {
                        Name = "Dune",
                        Category = "Book",
                        ImageUrl = "/img/matrix/dune.jpg",
                        Atmosphere = 4,
                        Lore = 5,
                        Depth = 5,
                        Balance = 4
                    }
                }
            };

            ViewBag.Matrix = matrix;
            return View();
        }
    }
}

