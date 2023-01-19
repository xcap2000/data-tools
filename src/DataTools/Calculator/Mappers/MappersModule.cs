namespace CarpeDiem.DataTools.Calculator.Mappers;

public class MappersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculatorModelMapper>()
            .As<ICalculatorModelMapper>()
            .SingleInstance();
        builder
            .RegisterType<SumRequestMapper>()
            .As<ISumRequestMapper>()
            .SingleInstance();
        builder
            .RegisterType<SumResponseMapper>()
            .As<ISumResponseMapper>()
            .SingleInstance();
    }
}