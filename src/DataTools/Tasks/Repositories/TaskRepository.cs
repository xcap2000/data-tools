using System.Threading.Tasks;
using CarpeDiem.DataTools.Common.Contexts;
using CarpeDiem.DataTools.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Tasks.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly IContext context;

    public TaskRepository(IContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<ITask>> ListAsync(int page, int pageSize)
    {
        return await context.Tasks
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}