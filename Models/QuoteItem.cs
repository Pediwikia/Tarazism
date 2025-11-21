namespace Tarazism.Models
{
    public class QuoteItem
    {
        public string Text { get; set; } = "";
        public string Author { get; set; } = "";
        public string? Source { get; set; } = null; // optional anime/book/etc
    }
}
