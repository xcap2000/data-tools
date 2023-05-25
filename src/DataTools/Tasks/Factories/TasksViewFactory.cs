using CarpeDiem.DataTools.Common.Factories;
using CarpeDiem.DataTools.Common.Resolvers;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks.Factories;

public class TasksViewFactory : BaseFactory<ITasksView>, ITasksViewFactory
{
    public TasksViewFactory(IResolver<ITasksView> resolver)
        : base(resolver)
    {
    }
}