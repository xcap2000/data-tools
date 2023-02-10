using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Mappers;
using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Services;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public class TasksPresenter : ITasksPresenter
{
    private readonly ITasksModel model;
    private readonly ITasksView view;
    private readonly ITaskService service;
    private readonly IListTaskRequestMapper listTaskRequestMapper;
    private readonly ITasksModelMapper tasksModelMapper;

    public TasksPresenter
    (
        ITasksModel model,
        ITasksView view,
        ITaskService service,
        IListTaskRequestMapper listTaskRequestMapper,
        ITasksModelMapper tasksModelMapper
    )
    {
        this.model = model;
        this.view = view;
        this.service = service;
        this.listTaskRequestMapper = listTaskRequestMapper;
        this.tasksModelMapper = tasksModelMapper;
    }

    public async Task InitializeAsync()
    {
        var request = listTaskRequestMapper.Map(model);

        var response = await service.ListAsync(request)
            .ConfigureAwait(false);

        tasksModelMapper.Map(model, response);

        view.Bind();
    }
}