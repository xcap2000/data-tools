using CarpeDiem.DataTools.Tasks.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Tasks.Contexts;

public class TasksContext : DbContext, ITasksContext
{
    public TasksContext(DbContextOptions<TasksContext> options)
        : base(options)
    {
    }

    DbSet<Task> ITasksContext.Tasks => Set<Task>();
}
