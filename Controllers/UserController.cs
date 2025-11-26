using Microsoft.AspNetCore.Mvc;
using Tarazism.Models;

namespace Tarazism.Controllers
{
    public class UserController : Controller
    {
        // demo profile
        public IActionResult Profile(string username = "demo")
        {
            var u = new UserProfileViewModel
            {
                Username = username,
                DisplayName = "Demo User",
                AvatarUrl = "/img/default-avatar.png",
                Badges = new List<string> { "Curator", "Reviewer" },
                Bio = "Loves balance, books and calm evenings."
            };
            return View(u);
        }
    }
}
