namespace Models;
using Microsoft.EntityFrameworkCore;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoDocument> TodoItems { get; set; } = null!;
}