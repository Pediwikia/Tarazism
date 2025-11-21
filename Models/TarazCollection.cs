namespace Tarazism.Models
{
    public class TarazCollection
    {
        public string Title { get; set; } = "";
        public string Subtitle { get; set; } = "";
        public List<CollectionItem> Items { get; set; } = new();
    }

    public class CollectionItem
    {
        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Category { get; set; } = "";
    }
}
