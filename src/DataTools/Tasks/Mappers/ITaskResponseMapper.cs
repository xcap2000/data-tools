using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public interface ITaskResponseMapper
{
    IReadOnlyList<ITaskResponse> Map(IEnumerable<ITask> tasks);
}