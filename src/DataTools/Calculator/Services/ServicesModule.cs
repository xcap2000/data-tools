using Autofac;

namespace CarpeDiem.DataTools.Calculator.Services;

public class ServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculatorService>()
            .As<ICalculatorService>()
            .SingleInstance();
    }
}