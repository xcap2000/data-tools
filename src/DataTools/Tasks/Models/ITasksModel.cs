using System.ComponentModel;

namespace CarpeDiem.DataTools.Tasks.Models;

public interface ITasksModel
{
    int Page { get; }
    int PageSize { get; }
    IList<ITaskModel> Tasks { get; }
}