using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public interface ITaskResponseMapper
{
    IEnumerable<ITaskResponse> Map(IEnumerable<ITask> tasks);
}