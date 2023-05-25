namespace CarpeDiem.DataTools.Tasks.Requests;

public class RequestsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<ListRequest>()
            .As<IListRequest>()
            .InstancePerDependency();
    }
}