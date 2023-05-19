using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Mappers;
using CarpeDiem.DataTools.Tasks.Repositories;
using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository repository;
    private readonly IListResponseMapper listResponseMapper;

    public TaskService
    (
        ITaskRepository repository,
        IListResponseMapper listResponseMapper
    )
    {
        this.repository = repository;
        this.listResponseMapper = listResponseMapper;
    }

    public async Task<IListResponse> ListAsync(IListRequest request)
    {
        var tasks = await repository.ListAsync(request.Page, request.PageSize);

        return listResponseMapper.Map(tasks);
    }
}