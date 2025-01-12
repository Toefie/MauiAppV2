using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MauiApp2.Database;
using MauiApp2.Models;

namespace MauiApp2.ViewModels
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
        private PlayerRepository _repository;

        public ObservableCollection<Player> Players { get; set; }
        public string NewPlayerName { get; set; }
        public int NewPlayerScore { get; set; }

        public ICommand AddPlayerCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public PlayerViewModel()
        {
            _repository = new PlayerRepository();
            Players = new ObservableCollection<Player>(_repository.GetAllPlayers());

            AddPlayerCommand = new Command(AddPlayer);
        }

        private void AddPlayer()
        {
            if (!string.IsNullOrEmpty(NewPlayerName))
            {
                var newPlayer = new Player { Name = NewPlayerName };
                _repository.AddPlayer(newPlayer);
                Players.Add(newPlayer);

                // Reset inputs
                NewPlayerName = string.Empty;
                NewPlayerScore = 0;
                OnPropertyChanged(nameof(NewPlayerName));
                OnPropertyChanged(nameof(NewPlayerScore));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
