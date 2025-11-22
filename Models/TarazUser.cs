namespace Tarazism.Models
{
    public class TarazUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Bio { get; set; } = "No bio yet.";
        public string AvatarUrl { get; set; } = "/img/default-avatar.png";
        public DateTime Joined { get; set; } = DateTime.UtcNow;
    }
}
