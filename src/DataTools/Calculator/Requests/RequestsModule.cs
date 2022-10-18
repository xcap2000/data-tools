namespace CarpeDiem.DataTools.Calculator.Requests;

public class RequestsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<SumRequest>()
            .As<ISumRequestReader>()
            .As<ISumRequestWriter>()
            .As<ISumRequest>()
            .InstancePerDependency();
    }
}