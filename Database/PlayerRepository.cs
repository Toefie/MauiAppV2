using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp2.Models;
using SQLite;


namespace MauiApp2.Database
{
    public class PlayerRepository
    {
        SQLiteConnection connection;
        public string? statusMessage {  get; set; }
        
        public PlayerRepository()
        {
            connection = new SQLiteConnection(
                Constants.DatabasePath,
                Constants.flags );
            connection.CreateTable<Player>();
        }
   
        public void Add( Player newPlayer )
        {
            int result = 0;
            try
            {
                result = connection.Insert(newPlayer);
                statusMessage = $"{result} row(s) added";
            }
            catch (Exception ex)
            { 
                statusMessage = $"Error: {ex.Message}";
            
            }

        }
    }
}
