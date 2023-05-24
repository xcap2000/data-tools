using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public interface ITasksModelMapper
{
    void Map(ITasksModel model, IListResponse response);
}