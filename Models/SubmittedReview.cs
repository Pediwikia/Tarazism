namespace Tarazism.Models
{
    public class SubmittedReview
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; } = "";
        public string ReviewerAvatarUrl { get; set; } = "/img/default-avatar.png";
        public int Rating { get; set; } = 5;
        public string ReviewText { get; set; } = "";
        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
        public string? ItemTitle { get; set; }  // optional: which item this review is for
    }
}
