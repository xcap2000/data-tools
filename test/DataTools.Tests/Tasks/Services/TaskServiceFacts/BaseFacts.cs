namespace CarpeDiem.DataTools.Tasks.Services;

public static partial class TaskServiceFacts
{
    [Collection(TasksCollection.NAME)]
    public abstract class BaseFacts
    {
        protected readonly ITaskService service;

        protected BaseFacts(TasksFixture fixture)
        {
            service = fixture.Container.Resolve<ITaskService>();
        }
    }
}