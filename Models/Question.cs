using SQLite;

namespace MauiApp2.Models
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Text { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
    }
}