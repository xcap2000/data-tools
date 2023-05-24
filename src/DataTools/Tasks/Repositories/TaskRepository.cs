using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Contexts;
using CarpeDiem.DataTools.Tasks.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Tasks.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ITasksContext context;

    public TaskRepository(ITasksContext context)
    {
        this.context = context;
    }

    public async Task<int> CountAsync()
    {
        return await context.Tasks.CountAsync();
    }

    public async Task<IEnumerable<ITask>> ListAsync(int page, int pageSize)
    {
        return await context.Tasks
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}