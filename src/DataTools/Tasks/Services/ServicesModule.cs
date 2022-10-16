using Autofac;

namespace CarpeDiem.DataTools.Tasks.Services;

public class ServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TaskService>()
            .As<ITaskService>()
            .SingleInstance();
    }
}