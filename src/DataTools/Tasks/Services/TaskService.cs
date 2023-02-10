using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Repositories;
using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository repository;

    public TaskService(ITaskRepository repository)
    {
        this.repository = repository;
    }

    public Task<IListTaskResponse> ListAsync(IListTaskRequest listTaskRequest)
    {
        throw new NotImplementedException();
    }
}