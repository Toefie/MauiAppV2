using SQLite;
using System.Collections.Generic;
using System.IO;
using MauiApp2.Models;

namespace MauiApp2.Database
{
    public class QuestionRepository
    {
        private readonly SQLiteConnection _database;

        public QuestionRepository()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "questions.db");
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Question>();
        }

        public List<Question> GetAllQuestions()
        {
            return _database.Table<Question>().ToList();
        }

        public void AddQuestion(Question question)
        {
            _database.Insert(question);
        }

        public void DeleteQuestion(Question question)
        {
            _database.Delete(question);
        }

        public void UpdateQuestion(Question question)
        {
            _database.Update(question);
        }
    }
}