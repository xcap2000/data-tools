using CarpeDiem.DataTools.Tasks.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public interface IListResponseMapper
{
    IListResponse Map(int total, IEnumerable<ITask> tasks);
}