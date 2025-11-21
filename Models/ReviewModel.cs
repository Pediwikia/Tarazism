namespace Tarazism.Models
{
    public class ReviewModel
    {
        public string? ReviewerName { get; set; }
        public string? ReviewerAvatarUrl { get; set; }
        public int Rating { get; set; } // 1–5
        public string? ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
