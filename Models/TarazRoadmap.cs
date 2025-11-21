namespace Tarazism.Models
{
    public class RoadmapMilestone
    {
        public string Title { get; set; } = "";
        public string Status { get; set; } = ""; // Planned / In Progress / Done
        public string Icon { get; set; } = "";
    }

    public class TarazRoadmap
    {
        public string Year { get; set; } = "";
        public List<RoadmapMilestone> Milestones { get; set; } = new();
    }
}
