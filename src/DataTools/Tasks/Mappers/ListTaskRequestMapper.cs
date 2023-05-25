using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Requests;

namespace CarpeDiem.DataTools.Tasks;

public class ListTaskRequestMapper : IListTaskRequestMapper
{
    public IListRequest Map(ITasksModel model)
    {
        return new ListRequest(model.Page, model.PageSize);
    }
}