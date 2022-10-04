using Autofac;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class PresentersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<MiniCalcPresenter>()
            .Named<IMiniCalcPresenter>(nameof(IMiniCalcPresenter))
            .SingleInstance();

        builder
            .RegisterType<LazyMiniCalcPresenter>()
            .As<IMiniCalcPresenter>()
            .SingleInstance();
    }
}