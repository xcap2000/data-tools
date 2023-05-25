namespace CarpeDiem.DataTools.Tasks.Models;

public class ModelsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TaskModel>()
            .As<ITaskModel>()
            .SingleInstance();

        builder
            .RegisterType<TasksModel>()
            .As<ITasksModel>()
            .SingleInstance();
    }
}