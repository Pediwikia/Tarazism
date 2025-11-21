using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class SearchController : Controller
    {
        // sample search over static data - replace with DB queries later
        private List<string> SampleItems = new() { "Dune", "Spirited Away", "Elden Ring", "Your Name" };

        public IActionResult Results(string q)
        {
            ViewData["Query"] = q;
            if (string.IsNullOrWhiteSpace(q)) return View(new List<string>());
            var results = SampleItems.Where(s => s.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
            return View(results);
        }
    }
}
