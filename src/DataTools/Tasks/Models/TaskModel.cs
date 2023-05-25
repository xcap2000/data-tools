using CarpeDiem.DataTools.Common.Models;

namespace CarpeDiem.DataTools.Tasks.Models;

public class TaskModel : BaseModel, ITaskModel
{
    public TaskModel(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}