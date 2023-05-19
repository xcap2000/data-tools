using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public class TaskResponseMapper : ITaskResponseMapper
{
    public IEnumerable<ITaskResponse> Map(IEnumerable<ITask> tasks)
    {
        var responses = new List<ITaskResponse>();

        foreach (var task in tasks)
        {
            var response = new TaskResponse
            {
                Id = task.Id
            };
            responses.Add(response);
        }

        return responses;
    }
}