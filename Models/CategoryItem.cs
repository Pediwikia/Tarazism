namespace Tarazism.Models
{
    public class CategoryItem
    {
        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";

        // New fields
        public List<string> Tags { get; set; } = new();
        public float Rating { get; set; } = 0;
        public string Author { get; set; } = "";
        public string Year { get; set; } = "";
    }
}
