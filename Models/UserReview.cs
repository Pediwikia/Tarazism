namespace Tarazism.Models
{
    public class UserReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public TarazUser User { get; set; }
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public int Score { get; set; }
        public string ReviewText { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
