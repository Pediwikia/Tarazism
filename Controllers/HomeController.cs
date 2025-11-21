using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var timeline = new TarazTimeline
            {
                Title = "Journey Through Balance",
                Items = new()
                {
                    new TimelineItem {
                        Year = "2019",
                        Heading = "The Idea of Tarazism",
                        Description = "The philosophy begins here — the search for balance in art, life, and expression.",
                        ImageUrl = "/img/timeline/idea.jpg"
                    },
                    new TimelineItem {
                        Year = "2021",
                        Heading = "Curation Style Emerges",
                        Description = "Anime, books, and games are analyzed with depth and harmony.",
                        ImageUrl = "/img/timeline/curation.jpg"
                    },
                    new TimelineItem {
                        Year = "2025",
                        Heading = "Tarazism Website Launch",
                        Description = "Tarazism becomes a digital philosophy — sharing balance with the world.",
                        ImageUrl = "/img/timeline/website.jpg"
                    }
                }
            };

            ViewBag.Timeline = timeline;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }    }
