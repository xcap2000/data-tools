using CarpeDiem.DataTools.Tasks.Contexts;

namespace CarpeDiem.DataTools.Tasks.Services;

public static partial class TaskServiceFacts
{
    [Collection(TasksCollection.NAME)]
    public abstract class BaseFacts
    {
        protected readonly ITasksContext context;
        protected readonly ITaskService service;

        protected BaseFacts(TasksFixture fixture)
        {
            context = fixture.Container.Resolve<ITasksContext>();
            service = fixture.Container.Resolve<ITaskService>();
        }
    }
}