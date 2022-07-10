using Autofac;

namespace CarpeDiem.DataTools.Calculator.Views;

public class ViewsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<MiniCalcView>()
            .As<IMiniCalcView>()
            .SingleInstance();
    }
}