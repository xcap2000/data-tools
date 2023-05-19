using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public class TaskResponseMapper : ITaskResponseMapper
{
    public IReadOnlyList<ITaskResponse> Map(IEnumerable<ITask> tasks)
    {
        var responses = new List<ITaskResponse>();

        foreach (var task in tasks)
        {
            responses.Add(Map(task));
        }

        return responses;
    }

    private static TaskResponse Map(ITask task)
    {
        return new TaskResponse
        {
            Id = task.Id
        };
    }
}