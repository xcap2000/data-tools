using CarpeDiem.DataTools.Common.Contexts;

namespace CarpeDiem.DataTools.Tasks.Services;

public static partial class TaskServiceFacts
{
    [Collection(TasksCollection.NAME)]
    public abstract class BaseFacts
    {
        protected readonly IContext context;
        protected readonly ITaskService service;

        protected BaseFacts(TasksFixture fixture)
        {
            context = fixture.Container.Resolve<IContext>();
            service = fixture.Container.Resolve<ITaskService>();
        }
    }
}