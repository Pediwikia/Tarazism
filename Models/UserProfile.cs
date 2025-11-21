namespace Tarazism.Models
{
    public class UserProfile
    {
        public string Username { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public string AvatarUrl { get; set; } = "/img/default-avatar.png";
        public List<string> Badges { get; set; } = new();
        public string Bio { get; set; } = "";
    }
}
