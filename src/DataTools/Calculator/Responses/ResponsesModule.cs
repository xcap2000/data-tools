namespace CarpeDiem.DataTools.Calculator.Responses;

public class ResponsesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<SumResponse>()
            .As<ISumResponse>()
            .InstancePerDependency();
    }
}