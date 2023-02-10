using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

// TODO - Implement.
public interface ITasksModelMapper
{
    void Map(ITasksModel model, IListTaskResponse reponse);
}