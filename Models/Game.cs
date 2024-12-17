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
    new Question { Text = "If you could live anywhere in the world, where would it be?", Category = "Truth", Difficulty = 2 },
    new Question { Text = "Hold a wall sit for 30 seconds.", Category = "Dare", Difficulty = 3 },
    new Question { Text = "Whistle your favorite tune for 20 seconds.", Category = "Wildcard", Difficulty = 4 },
    new Question { Text = "What is the most ridiculous rumor you’ve heard about yourself?", Category = "Truth", Difficulty = 1 },
    new Question { Text = "Imitate your favorite movie character for 1 minute.", Category = "Dare", Difficulty = 2 },
    new Question { Text = "Pretend to speak in a foreign language for 2 minutes.", Category = "Wildcard", Difficulty = 5 },
    new Question { Text = "What was your funniest childhood memory?", Category = "Truth", Difficulty = 2 },
    new Question { Text = "Do a silly walk across the room.", Category = "Dare", Difficulty = 1 },
    new Question { Text = "Tell a joke that makes everyone laugh.", Category = "Truth", Difficulty = 3 },
    new Question { Text = "What is a hidden talent of yours?", Category = "Truth", Difficulty = 2 },
    new Question { Text = "Spin around 10 times and walk in a straight line.", Category = "Dare", Difficulty = 3 },
    new Question { Text = "Hum a song and let others guess what it is.", Category = "Wildcard", Difficulty = 4 },
    new Question { Text = "What is something you are proud of?", Category = "Truth", Difficulty = 1 },
    new Question { Text = "Do an impression of someone in the room.", Category = "Dare", Difficulty = 2 },
    new Question { Text = "Pretend you are a superhero and show off your moves.", Category = "Wildcard", Difficulty = 5 },
    new Question { Text = "What was the last lie you told?", Category = "Truth", Difficulty = 2 },
    new Question { Text = "Hop on one foot for 30 seconds.", Category = "Dare", Difficulty = 1 },
    new Question { Text = "Describe your dream vacation.", Category = "Truth", Difficulty = 3 },
    new Question { Text = "Share the most random fact you know.", Category = "Truth", Difficulty = 2 },
    new Question { Text = "Do your best animal impression.", Category = "Dare", Difficulty = 3 },
    new Question { Text = "Act like a robot for 1 minute.", Category = "Wildcard", Difficulty = 4 },
    new Question { Text = "What is the funniest thing that ever happened to you?", Category = "Truth", Difficulty = 1 },
    new Question { Text = "Do a dance move nobody has seen before.", Category = "Dare", Difficulty = 2 },
    new Question { Text = "Pretend to be a news anchor and give a funny report.", Category = "Wildcard", Difficulty = 5 },
    new Question { Text = "What is the weirdest food you have ever tried?", Category = "Truth", Difficulty = 3 }
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
