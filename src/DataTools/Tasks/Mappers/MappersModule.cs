namespace CarpeDiem.DataTools.Tasks.Mappers;

public class MappersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TaskResponseMapper>()
            .As<ITaskResponseMapper>()
            .SingleInstance();
    }
}