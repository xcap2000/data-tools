using CarpeDiem.DataTools.Tasks.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Tasks.Contexts;

public class TasksContext : DbContext, ITasksContext
{
    public TasksContext(DbContextOptions<TasksContext> options)
        : base(options)
    {
    }

    public DbSet<Task> Tasks => Set<Task>();

    public void InitializeDatabase()
    {
        Database.Migrate();
    }
}
