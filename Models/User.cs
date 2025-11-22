namespace Tarazism.Models
{
    public class TarazUser
    {
        public int Id { get; set; }

        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = ""; // for now simple hash

        public string AvatarUrl { get; set; } = "/img/default-avatar.png";
        public string Bio { get; set; } = "No bio yet.";

        public DateTime Joined { get; set; } = DateTime.UtcNow;
    }
}
