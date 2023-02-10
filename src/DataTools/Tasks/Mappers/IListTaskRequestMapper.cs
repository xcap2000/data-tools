using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Requests;

namespace CarpeDiem.DataTools.Tasks;

// TODO - Implement.
public interface IListTaskRequestMapper
{
    IListTaskRequest Map(ITasksModel model);
}