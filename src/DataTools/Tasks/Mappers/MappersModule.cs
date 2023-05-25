namespace CarpeDiem.DataTools.Tasks.Mappers;

public class MappersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<ListResponseMapper>()
            .As<IListResponseMapper>()
            .SingleInstance();

        builder
            .RegisterType<ListTaskRequestMapper>()
            .As<IListTaskRequestMapper>()
            .SingleInstance();

        builder
            .RegisterType<TaskResponseMapper>()
            .As<ITaskResponseMapper>()
            .SingleInstance();

        builder
            .RegisterType<TasksModelMapper>()
            .As<ITasksModelMapper>()
            .SingleInstance();
    }
}