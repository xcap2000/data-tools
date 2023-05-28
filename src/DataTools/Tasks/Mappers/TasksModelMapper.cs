using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public class TasksModelMapper : ITasksModelMapper
{
    public void Map(ITasksModel model, IListResponse response)
    {
        foreach (var task in response.Tasks)
        {
            model.Tasks.Add(new TaskModel(task.Id));
        }
    }
}