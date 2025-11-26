using Tarazism.Models.ViewModels;

namespace Tarazism.Models
{
    public class UserProfileViewModel
    {
        public string Username { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public string AvatarUrl { get; set; } = "/img/default-avatar.png";
        public List<string> Badges { get; set; } = new();
        public string Bio { get; set; } = "";

        public List<ReviewViewModel> RecentReviews { get; set; } = new();
    }
}
