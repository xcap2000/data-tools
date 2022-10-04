using System;
using Autofac;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class LazyMiniCalcPresenter : IMiniCalcPresenter
{
    private readonly Lazy<IMiniCalcPresenter> presenterLazy;

    public LazyMiniCalcPresenter(ILifetimeScope scope)
    {
        presenterLazy = new Lazy<IMiniCalcPresenter>
        (
            () => scope.ResolveNamed<IMiniCalcPresenter>(nameof(IMiniCalcPresenter))
        );
    }

    public void Initialize()
    {
        presenterLazy.Value.Initialize();
    }

    public void Sum()
    {
        presenterLazy.Value.Sum();
    }
}