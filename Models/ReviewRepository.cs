using System.Collections.Concurrent;

namespace Tarazism.Models
{
    public static class ReviewRepository
    {
        private static readonly ConcurrentBag<SubmittedReview> _reviews = new();

        static ReviewRepository()
        {
            // seed
            _reviews.Add(new SubmittedReview
            {
                Id = 1,
                ReviewerName = "Alex Morgan",
                Rating = 5,
                ReviewText = "Balanced and thoughtful curation.",
                ReviewDate = DateTime.UtcNow.AddDays(-20)
            });
            _reviews.Add(new SubmittedReview
            {
                Id = 2,
                ReviewerName = "Layla Khan",
                Rating = 4,
                ReviewText = "Great finds!",
                ReviewDate = DateTime.UtcNow.AddDays(-10)
            });
        }

        public static IEnumerable<SubmittedReview> GetAll() => _reviews.OrderByDescending(r => r.ReviewDate);

        public static void Add(SubmittedReview r)
        {
            r.Id = _reviews.Count + 1;
            r.ReviewDate = DateTime.UtcNow;
            _reviews.Add(r);
        }

        public static IEnumerable<SubmittedReview> ForItem(string title) =>
            _reviews.Where(r => string.Equals(r.ItemTitle, title, StringComparison.OrdinalIgnoreCase));
    }
}
