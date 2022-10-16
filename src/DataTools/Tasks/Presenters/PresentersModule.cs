using Autofac;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public class PresentersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TasksPresenter>()
            .Named<ITasksPresenter>(nameof(ITasksPresenter))
            .SingleInstance();

        builder
            .RegisterType<LazyTasksPresenter>()
            .As<ITasksPresenter>()
            .SingleInstance();
    }
}