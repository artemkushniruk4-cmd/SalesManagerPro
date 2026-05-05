using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
}


public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Для WPF найпростіше почати з SQLite (локальний файл бази)
        // Коли буде серверна БД, просто заміниш UseSqlite на UseSqlServer
        optionsBuilder.UseSqlite("Data Source=users_app.db");
    }

    public AppDbContext()
    {
        // Цей рядок автоматично створить файл бази при запуску, якщо його немає
        Database.EnsureCreated();
    }
}
