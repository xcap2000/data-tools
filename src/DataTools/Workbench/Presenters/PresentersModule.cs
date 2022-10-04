using Autofac;

namespace CarpeDiem.DataTools.Workbench.Presenters;

public class PresentersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<WorkbenchPresenter>()
            .Named<IWorkbenchPresenter>(nameof(IWorkbenchPresenter))
            .SingleInstance();

        builder
            .RegisterType<LazyWorkbenchPresenter>()
            .As<IWorkbenchPresenter>()
            .SingleInstance();
    }
}