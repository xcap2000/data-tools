namespace CarpeDiem.DataTools.Tasks.Responses;

public class ResponsesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<ListResponse>()
            .As<IListResponse>()
            .InstancePerDependency();

        builder
            .RegisterType<TaskResponse>()
            .As<ITaskResponse>()
            .InstancePerDependency();
    }
}