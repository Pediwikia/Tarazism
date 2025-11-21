namespace Tarazism.Models
{
    public class UpcomingItem
    {
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string ImageUrl { get; set; } = "";
    }
}
