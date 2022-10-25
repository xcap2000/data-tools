namespace CarpeDiem.DataTools.Calculator.Factories;

public class FactoriesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculatorViewFactory>()
            .As<ICalculatorViewFactory>()
            .SingleInstance();
        builder
            .RegisterType<SumRequestFactory>()
            .As<ISumRequestFactory>()
            .SingleInstance();
        builder
            .RegisterType<SumResponseFactory>()
            .As<ISumResponseFactory>()
            .SingleInstance();
    }
}