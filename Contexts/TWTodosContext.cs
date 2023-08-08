using Microsoft.EntityFrameworkCore;
using TWTodos.Models;

namespace TWTodos.Contexts;

public class TWTodosContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
    }
}