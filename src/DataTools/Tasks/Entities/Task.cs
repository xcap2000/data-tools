namespace CarpeDiem.DataTools.Tasks.Entities;

public class Task : ITask
{
    public Task(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}