using SQLite;
using MauiApp2.Models;

namespace MauiApp2.Database
{
    public class PlayerRepository
    {
        private SQLiteConnection connection;

        public PlayerRepository()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);
            connection.CreateTable<Player>();
        }

        public void AddPlayer(Player player)
        {
            connection.Insert(player);
        }

        public List<Player> GetAllPlayers()
        {
            return connection.Table<Player>().ToList();
        }

        public void DeletePlayer(int playerId)
        {
            connection.Delete<Player>(playerId);
        }
    }
}


