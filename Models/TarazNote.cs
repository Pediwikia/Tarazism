namespace Tarazism.Models
{
    public class TarazNote
    {
        public string Title { get; set; } = "";
        public string Text { get; set; } = "";
        public string Category { get; set; } = "";
        public string? Icon { get; set; } = null;  // optional emoji/icon

        // Add these properties to match usage in Index.cshtml
        public string Quote { get; set; } = "";
        public string Author { get; set; } = "";
        public string Accent { get; set; } = "";
    }
}
