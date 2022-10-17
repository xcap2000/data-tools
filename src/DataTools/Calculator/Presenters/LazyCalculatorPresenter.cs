using System;
using Autofac;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class LazyCalculatorPresenter : ICalculatorPresenter
{
    private readonly Lazy<ICalculatorPresenter> presenterLazy;

    public LazyCalculatorPresenter(ILifetimeScope scope)
    {
        presenterLazy = new Lazy<ICalculatorPresenter>
        (
            () => scope.ResolveNamed<ICalculatorPresenter>(nameof(ICalculatorPresenter))
        );
    }

    public void Initialize()
    {
        presenterLazy.Value.Initialize();
    }

    public void Sum(object? sender, EventArgs e)
    {
        presenterLazy.Value.Sum(sender, e);
    }
}