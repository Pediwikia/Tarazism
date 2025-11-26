namespace Tarazism.Models.ViewModels
{
    public class ReviewViewModel
    {
        public string ReviewerName { get; set; } = "";
        public string ReviewerAvatarUrl { get; set; } = "/img/default-avatar.png";
        public int Rating { get; set; }
        public string ReviewText { get; set; } = "";
        public DateTime ReviewDate { get; set; }
    }
}
