using MauiApp2.Database;
using MauiApp2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp2.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        private readonly QuestionRepository _repository;

        public ObservableCollection<Question> Questions { get; set; }

        public string NewQuestionText { get; set; }
        public string NewQuestionCategory { get; set; }
        public int NewQuestionDifficulty { get; set; }

        public ICommand AddQuestionCommand { get; }
        public ICommand DeleteQuestionCommand { get; }
        public ICommand UpdateQuestionCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public QuestionViewModel()
        {
            _repository = new QuestionRepository();
            Questions = new ObservableCollection<Question>(_repository.GetAllQuestions());

            AddQuestionCommand = new Command(AddQuestion);
            DeleteQuestionCommand = new Command<Question>(DeleteQuestion);
            UpdateQuestionCommand = new Command<Question>(UpdateQuestion);
        }

        private void AddQuestion()
        {
            if (!string.IsNullOrEmpty(NewQuestionText) && !string.IsNullOrEmpty(NewQuestionCategory))
            {
                var newQuestion = new Question
                {
                    Text = NewQuestionText,
                    Category = NewQuestionCategory,
                    Difficulty = NewQuestionDifficulty
                };

                _repository.AddQuestion(newQuestion);
                Questions.Add(newQuestion);

                // Reset invoervelden
                NewQuestionText = string.Empty;
                NewQuestionCategory = string.Empty;
                NewQuestionDifficulty = 0;

                OnPropertyChanged(nameof(NewQuestionText));
                OnPropertyChanged(nameof(NewQuestionCategory));
                OnPropertyChanged(nameof(NewQuestionDifficulty));
            }
        }

        private void DeleteQuestion(Question question)
        {
            if (question != null)
            {
                _repository.DeleteQuestion(question);
                Questions.Remove(question);
            }
        }

        private void UpdateQuestion(Question question)
        {
            if (question != null)
            {
                _repository.UpdateQuestion(question);

                // Forceer een refresh van de lijst
                var index = Questions.IndexOf(question);
                if (index >= 0)
                {
                    Questions[index] = question;
                }
                OnPropertyChanged(nameof(Questions));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}