namespace Tarazism.Models
{
    public class Collection
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> ItemTitles { get; set; } = new();
    }
}
