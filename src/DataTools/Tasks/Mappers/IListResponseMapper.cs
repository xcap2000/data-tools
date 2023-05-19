using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public interface IListResponseMapper
{
    IListResponse Map(IEnumerable<ITask> tasks);
}