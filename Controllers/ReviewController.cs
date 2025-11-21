using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var all = ReviewRepository.GetAll().ToList();
            return View(all);
        }

        [HttpPost]
        public IActionResult Submit([FromForm] SubmittedReview model)
        {
            if (string.IsNullOrWhiteSpace(model.ReviewerName) || string.IsNullOrWhiteSpace(model.ReviewText))
            {
                TempData["Error"] = "Please provide name and review text.";
                return RedirectToAction("Index");
            }
            ReviewRepository.Add(model);
            TempData["Success"] = "Thanks — your review was submitted.";
            return RedirectToAction("Index");
        }
    }
}
