namespace Tarazism.Models
{
    public class MediaMatrix
    {
        public string Title { get; set; } = "";
        public List<MatrixItem> Items { get; set; } = new();
    }

    public class MatrixItem
    {
        public string Name { get; set; } = "";
        public string Category { get; set; } = ""; // Anime, Book, Game...
        public string ImageUrl { get; set; } = "";

        public int Atmosphere { get; set; } // 1–5 stars
        public int Lore { get; set; }
        public int Depth { get; set; }
        public int Balance { get; set; }
    }
}
