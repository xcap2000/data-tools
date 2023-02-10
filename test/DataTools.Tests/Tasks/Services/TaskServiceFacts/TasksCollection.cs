namespace CarpeDiem.DataTools.Tasks.Services;

[CollectionDefinition(NAME)]
public class TasksCollection : ICollectionFixture<TasksFixture>
{
    public const string NAME = nameof(TasksCollection);
}