namespace Tarazism.Models
{
    public class TarazTimeline
    {
        public string Title { get; set; } = "";
        public List<TimelineItem> Items { get; set; } = new();
    }

    public class TimelineItem
    {
        public string Year { get; set; } = "";
        public string Heading { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Icon { get; set; } = "";
    }
}
