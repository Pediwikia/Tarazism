namespace Tarazism.Models
{
    public class TarazScore
    {
        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";

        public int Balance { get; set; }
        public int Craft { get; set; }
        public int Emotion { get; set; }
        public int Aesthetic { get; set; }

        public double Score =>
            (Balance + Craft + Emotion + Aesthetic) / 4.0;
    }
}
