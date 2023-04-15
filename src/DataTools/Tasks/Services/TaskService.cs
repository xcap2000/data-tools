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

    public async Task<IListResponse> ListAsync(IListRequest request)
    {
        var tasks = await repository.ListAsync(request.Page, request.PageSize);

        var taskResponses = new List<ITaskResponse>();

        // TODO - Create mapper.
        foreach (var task in tasks)
        {
            taskResponses.Add(new TaskResponse());
        }

        return new ListResponse(taskResponses);
    }
}