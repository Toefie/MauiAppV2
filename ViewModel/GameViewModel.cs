using MauiApp2.Models;
using MauiApp2.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp2.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private readonly GameService _gameService;

        public ObservableCollection<Question> Questions { get; set; }

        public ICommand LoadRandomQuestionsCommand { get; }
        public ICommand LoadQuestionsByCategoryCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public GameViewModel()
        {
            _gameService = new GameService();
            Questions = new ObservableCollection<Question>();

            LoadRandomQuestionsCommand = new Command(LoadRandomQuestions);
            LoadQuestionsByCategoryCommand = new Command<string>(LoadQuestionsByCategory);
        }

        private void LoadRandomQuestions()
        {
            var randomQuestions = _gameService.GetRandomQuestions(5);
            Questions.Clear();
            foreach (var question in randomQuestions)
            {
                Questions.Add(question);
            }
        }

        private void LoadQuestionsByCategory(string category)
        {
            var categoryQuestions = _gameService.GetQuestionsByCategory(category, 5);
            Questions.Clear();
            foreach (var question in categoryQuestions)
            {
                Questions.Add(question);
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
