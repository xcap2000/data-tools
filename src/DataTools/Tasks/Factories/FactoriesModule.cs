namespace CarpeDiem.DataTools.Tasks.Factories;

public class FactoriesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TasksViewFactory>()
            .As<ITasksViewFactory>()
            .SingleInstance();
    }
}