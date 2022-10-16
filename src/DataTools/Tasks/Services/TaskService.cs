using CarpeDiem.DataTools.Tasks.Repositories;

namespace CarpeDiem.DataTools.Tasks.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository repository;

    public TaskService(ITaskRepository repository)
    {
        this.repository = repository;
    }
}