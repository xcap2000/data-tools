namespace CarpeDiem.DataTools.Calculator.Presenters;

public class PresentersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculatorPresenter>()
            .Named<ICalculatorPresenter>(nameof(ICalculatorPresenter))
            .SingleInstance();

        builder
            .RegisterType<LazyCalculatorPresenter>()
            .As<ICalculatorPresenter>()
            .SingleInstance();
    }
}