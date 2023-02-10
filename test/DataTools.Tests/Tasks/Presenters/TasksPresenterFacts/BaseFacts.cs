using CarpeDiem.DataTools.Tasks.Mappers;
using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Services;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public static partial class TasksPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly ITasksModel model;
        protected readonly ITasksView view;
        protected readonly ITaskService service;
        protected readonly IListTaskRequestMapper listTaskRequestMapper;
        protected readonly ITasksModelMapper tasksModelMapper;
        protected readonly ITasksPresenter presenter;

        protected BaseFacts()
        {
            model = For<ITasksModel>();
            view = For<ITasksView>();
            service = For<ITaskService>();
            listTaskRequestMapper = For<IListTaskRequestMapper>();
            tasksModelMapper = For<ITasksModelMapper>();
            presenter = new TasksPresenter
            (
                model,
                view,
                service,
                listTaskRequestMapper,
                tasksModelMapper
            );
        }
    }
}