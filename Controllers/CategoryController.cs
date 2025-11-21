using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Books()
        {
            return View("CategoryView", GetItems("Books"));
        }

        public IActionResult Anime()
        {
            return View("CategoryView", GetItems("Anime"));
        }

        public IActionResult Games()
        {
            return View("CategoryView", GetItems("Games"));
        }

        private List<CategoryItem> GetItems(string category)
        {
            var items = new List<CategoryItem>
            {
                new CategoryItem {
                    Title = "Dune",
                    ImageUrl = "/img/covers/books.jpg",
                    Description = "A masterpiece of depth and balance.",
                    Category = "Books"
                },

                new CategoryItem {
                    Title = "Your Name",
                    ImageUrl = "/img/covers/anime.jpg",
                    Description = "A beautiful story of connection and destiny.",
                    Category = "Anime"
                },

                new CategoryItem {
                    Title = "Elden Ring",
                    ImageUrl = "/img/covers/games.jpg",
                    Description = "An unforgettable experience in an open world.",
                    Category = "Games"
                },
            };

            return items.Where(x => x.Category == category).ToList();
        }
    }
}
