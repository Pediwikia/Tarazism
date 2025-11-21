using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class CollectionController : Controller
    {
        private static readonly List<Collection> _collections = new()
        {
            new Collection {
                Id = "top-anime-2025",
                Title = "Top Anime 2025",
                Description = "Hand-picked anime for balance and depth.",
                ItemTitles = new() { "Spirited Away", "Your Name" }
            },
            new Collection {
                Id = "philosophy-reads",
                Title = "Philosophy Bundle",
                Description = "Books that bring mental clarity and balance.",
                ItemTitles = new() { "Dune" }
            }
        };

        public IActionResult Index() => View(_collections);

        public IActionResult Details(string id)
        {
            var col = _collections.FirstOrDefault(c => c.Id == id);
            if (col == null) return NotFound();
            return View(col);
        }
    }
}
