using Microsoft.EntityFrameworkCore;
using simple_aspnetcoremvc_todo.Models;

namespace simple_aspnetcoremvc_todo.Models
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options)
        {
        }

        public DbSet<TodoModel> Todos { get; set; }
    }
}