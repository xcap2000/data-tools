using CarpeDiem.DataTools.Common.Contexts;

namespace CarpeDiem.DataTools.Tasks.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly IContext context;

    public TaskRepository(IContext context)
    {
        this.context = context;
    }
}