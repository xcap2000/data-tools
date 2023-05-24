using CarpeDiem.DataTools.Tasks.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Tasks.Contexts;

public interface ITasksContext
{
    DbSet<Task> Tasks { get; }
}