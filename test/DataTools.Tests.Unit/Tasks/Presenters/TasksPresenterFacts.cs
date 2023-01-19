using CarpeDiem.DataTools.Common.Contexts;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public static class TasksPresenterFacts
{
    [Collection(TasksCollection.NAME)]
    public class TheInitializeMethod
    {
        private readonly IContext context;
        private readonly ITasksView view;
        private readonly ITasksPresenter presenter;

        public TheInitializeMethod(TasksFixture fixture)
        {
            context = fixture.Container.Resolve<IContext>();
            view = fixture.Container.Resolve<ITasksView>();
            presenter = fixture.Container.Resolve<ITasksPresenter>();
        }

        [Fact]
        public async void ListsActiveTasks()
        {
            // TODO - Continue.
            await presenter.InitializeAsync();

            // view.Received(1).Model = Arg.Any<ITasksModel>();
        }
    }
}