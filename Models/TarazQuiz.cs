namespace Tarazism.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; } = "";
        public List<string> Options { get; set; } = new();
    }

    public class QuizResult
    {
        public string Type { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
    }

    public class TarazQuiz
    {
        public List<QuizQuestion> Questions { get; set; } = new();
        public List<QuizResult> Results { get; set; } = new();
    }
}
