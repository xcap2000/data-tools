namespace CarpeDiem.DataTools.E2e.Tasks;

[CollectionDefinition(NAME)]
public class TasksCollection : ICollectionFixture<TasksFixture>
{
    public const string NAME = nameof(TasksCollection);
}