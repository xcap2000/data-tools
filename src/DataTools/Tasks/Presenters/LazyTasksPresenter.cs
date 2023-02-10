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

    // TODO - Maybe this is  good pattern to avoid ConfigureAwait(false) because it delegates to the real presenter
    public Task InitializeAsync()
    {
        return presenterLazy.Value.InitializeAsync();
    }
}