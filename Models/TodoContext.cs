using Microsoft.EntityFrameworkCore;
using TodoItems.Models;

namespace dotnetapitut.Models;

public class TodoContext: DbContext {
    public TodoContext(DbContextOptions<TodoContext>options):base(options){

    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}