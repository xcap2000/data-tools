namespace CarpeDiem.DataTools.Tasks.Models;

public class TaskModel : ITaskModel
{
    public TaskModel(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}