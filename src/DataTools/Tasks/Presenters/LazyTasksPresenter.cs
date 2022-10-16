using System;
using System.Threading.Tasks;
using Autofac;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public class LazyTasksPresenter : ITasksPresenter
{
    private readonly Lazy<ITasksPresenter> presenterLazy;

    public LazyTasksPresenter(ILifetimeScope scope)
    {
        presenterLazy = new Lazy<ITasksPresenter>
        (
            () => scope.ResolveNamed<ITasksPresenter>(nameof(ITasksPresenter))
        );
    }

    public async Task InitializeAsync()
    {
        await presenterLazy.Value.InitializeAsync();
    }
}