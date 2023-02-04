using Microsoft.EntityFrameworkCore;
using WebFrogs.Models.Entities;

namespace WebFrogs.Models
{
    public class Context : DbContext
    {
        public DbSet<Frog> Frogs { get; set; }
        public DbSet<Toad> Toads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Строка подключения к БД, используйте свою!
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2U1B2GA\SQLEXPRESS;Initial Catalog=WebFrogs;Integrated Security=true;");

            // В диспетчере пакетов примените миграцию (Update-Database), для создания двух таблиц
            // Выполните скрипт (scriptWithData.sql) для заполнения таблиц данными
        }
    }
}
