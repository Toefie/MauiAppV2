namespace MauiApp2;

public class Game
{
    private readonly List<Question> Questions = new List<Question>
    {
        new Question { Text = "What is your most embarrassing moment?", Category = "Truth", Difficulty = 2 },
        new Question { Text = "Do 20 push-ups.", Category = "Dare", Difficulty = 3 },
        new Question { Text = "Sing a song loudly.", Category = "Wildcard", Difficulty = 4 },
        new Question { Text = "What is your biggest fear?", Category = "Truth", Difficulty = 1 },
        new Question { Text = "Dance for 1 minute without music.", Category = "Dare", Difficulty = 2 },
        new Question { Text = "Act like a cat for the next 5 minutes.", Category = "Wildcard", Difficulty = 5 },
        new Question { Text = "Who was your first crush?", Category = "Truth", Difficulty = 2 },
        new Question { Text = "Run around the room twice.", Category = "Dare", Difficulty = 1 },
        new Question { Text = "Share a secret no one knows.", Category = "Truth", Difficulty = 3 },
    };

    public List<Question> GetRandomQuestions(int count)
    {
        var random = new Random();
        var selectedQuestions = Questions.OrderBy(q => random.Next()).Take(count).ToList();

        // Zorg ervoor dat er minstens één wildcardvraag is
        if (!selectedQuestions.Any(q => q.Category == "Wildcard"))
        {
            var wildcardQuestion = Questions.FirstOrDefault(q => q.Category == "Wildcard");
            if (wildcardQuestion != null)
            {
                selectedQuestions[0] = wildcardQuestion;
            }
        }

        return selectedQuestions;
    }

    public List<Question> GetQuestionsByCategory(string category, int count)
    {
        return Questions
            .Where(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .Take(count)
            .ToList();
    }
}
