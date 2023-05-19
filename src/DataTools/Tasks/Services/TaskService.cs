using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Mappers;
using CarpeDiem.DataTools.Tasks.Repositories;
using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository repository;
    private readonly ITaskResponseMapper taskResponseMapper;

    public TaskService
    (
        ITaskRepository repository,
        ITaskResponseMapper taskResponseMapper
    )
    {
        this.repository = repository;
        this.taskResponseMapper = taskResponseMapper;
    }

    public async Task<IListResponse> ListAsync(IListRequest request)
    {
        var tasks = await repository.ListAsync(request.Page, request.PageSize);

        var responses = taskResponseMapper.Map(tasks);

        return new ListResponse(responses);
    }
}