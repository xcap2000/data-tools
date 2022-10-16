using System;
using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Services;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public class TasksPresenter : ITasksPresenter
{
    private readonly ITaskService service;

    public TasksPresenter(ITaskService service)
    {
        this.service = service;
    }

    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }
}