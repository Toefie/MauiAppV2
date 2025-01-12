using MauiApp2.Models;
using MauiApp2.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MauiApp2.Services
{
    public class GameService
    {
        private readonly QuestionRepository _repository;

        public GameService()
        {
            _repository = new QuestionRepository();
            if (!_repository.GetAllQuestions().Any())
            {
                AddDefaultQuestions();
            }
        }

        private void AddDefaultQuestions()
        {
            var defaultQuestions = new List<Question>
            {
                new Question { Text = "What is your most embarrassing moment?", Category = "Truth", Difficulty = 2 },
                new Question { Text = "Do 20 push-ups.", Category = "Dare", Difficulty = 3 },
                new Question { Text = "Sing a song loudly.", Category = "Wildcard", Difficulty = 4 },
                new Question { Text = "What is your biggest fear?", Category = "Truth", Difficulty = 1 },
                new Question { Text = "Dance for 1 minute without music.", Category = "Dare", Difficulty = 2 },
            };

            foreach (var question in defaultQuestions)
            {
                _repository.AddQuestion(question);
            }
        }

        public List<Question> GetRandomQuestions(int count)
        {
            var allQuestions = _repository.GetAllQuestions();
            var random = new Random();
            var selectedQuestions = allQuestions.OrderBy(q => random.Next()).Take(count).ToList();

            if (!selectedQuestions.Any(q => q.Category == "Wildcard"))
            {
                var wildcardQuestion = allQuestions.FirstOrDefault(q => q.Category == "Wildcard");
                if (wildcardQuestion != null)
                {
                    selectedQuestions[0] = wildcardQuestion;
                }
            }

            return selectedQuestions;
        }

        public List<Question> GetQuestionsByCategory(string category, int count)
        {
            return _repository
                .GetAllQuestions()
                .Where(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .Take(count)
                .ToList();
        }
    }
}