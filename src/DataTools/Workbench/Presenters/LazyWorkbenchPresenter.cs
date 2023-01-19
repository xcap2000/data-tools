namespace CarpeDiem.DataTools.Workbench.Presenters;

// TODO - Create base or generic class.
// TODO - Create extension method for autofac to register presenters easily.
public class LazyWorkbenchPresenter : IWorkbenchPresenter
{
    private readonly Lazy<IWorkbenchPresenter> presenterLazy;

    public LazyWorkbenchPresenter(ILifetimeScope scope)
    {
        presenterLazy = new Lazy<IWorkbenchPresenter>
        (
            () => scope.ResolveNamed<IWorkbenchPresenter>(nameof(IWorkbenchPresenter))
        );
    }

    public void Initialize()
    {
        presenterLazy.Value.Initialize();
    }

    public void Close()
    {
        presenterLazy.Value.Close();
    }
}