namespace Tarazism.Models
{
    public class TrendingItem
    {
        public int Rank { get; set; }         // 1,2,3...
        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Category { get; set; } = "";
    }
}
