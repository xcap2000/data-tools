using Autofac;

namespace CarpeDiem.DataTools.Calculator.Models;

public class ModelsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculatorModel>()
            .As<ICalculatorModel>()
            .SingleInstance();
    }
}