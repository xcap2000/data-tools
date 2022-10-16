using Autofac;

namespace CarpeDiem.DataTools.Tasks.Repositories;

public class RepositoriesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TaskRepository>()
            .As<ITaskRepository>()
            .SingleInstance();
    }
}