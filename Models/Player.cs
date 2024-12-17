using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    [Table("Players")]

    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("Name"), Indexed, NotNull]
        public string Name { get; set; }

        [Unique]
        public string Password { get; set; }
    }
}
