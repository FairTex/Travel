using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class DatabaseContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public DatabaseContext() : base("TravelProject")
        { }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Base> Base { get; set; }
    }
}
