using System.ComponentModel;

namespace CarpeDiem.DataTools.Tasks.Models;

public class TasksModel : BindingList<ITaskModel>, ITasksModel
{
    public TasksModel()
    {
        AllowNew = false;
        AllowEdit = false;
        AllowRemove = false;
        RaiseListChangedEvents = false;
    }

    public int Page { get; } = 0;
    public int PageSize { get; } = 10;
}