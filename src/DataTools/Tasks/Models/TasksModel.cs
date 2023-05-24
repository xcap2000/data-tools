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
}