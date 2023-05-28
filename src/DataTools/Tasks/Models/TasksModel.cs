using System.ComponentModel;

namespace CarpeDiem.DataTools.Tasks.Models;

public class TasksModel : ITasksModel
{
    public int Page { get; } = 0;
    public int PageSize { get; } = 10;

    public IList<ITaskModel> Tasks { get; } = new List<ITaskModel>();
}