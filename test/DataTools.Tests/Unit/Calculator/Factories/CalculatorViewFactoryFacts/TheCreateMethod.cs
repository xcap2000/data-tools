using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Unit.Common.Factories;

namespace CarpeDiem.DataTools.Unit.Calculator.Factories;

public static class CalculatorViewFactoryFacts
{
    public class TheCreateMethod : BaseTheCreateMethod<ICalculatorView, ICalculatorViewFactory>
    {
        protected override ICalculatorViewFactory CreateFactory()
            => new CalculatorViewFactory(resolver);
    }
}