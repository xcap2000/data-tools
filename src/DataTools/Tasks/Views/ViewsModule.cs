namespace CarpeDiem.DataTools.Tasks.Views;

public class ViewsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TasksView>()
            .As<ITasksView>()
            .SingleInstance();
    }
}