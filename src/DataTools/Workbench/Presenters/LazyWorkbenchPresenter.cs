using System;
using Autofac;

namespace CarpeDiem.DataTools.Workbench.Presenters;

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