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
    }
}
