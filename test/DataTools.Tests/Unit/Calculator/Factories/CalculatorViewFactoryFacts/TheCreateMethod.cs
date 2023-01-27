using CarpeDiem.DataTools.Calculator.Factories;
using static CarpeDiem.DataTools.Unit.Common.Factories.BaseFactoryFacts;

namespace CarpeDiem.DataTools.Unit.Calculator.Factories;

public static partial class CalculatorViewFactoryFacts
{
    public class TheCreateMethod : BaseTheCreateMethod<ICalculatorView, ICalculatorViewFactory>
    {
        protected override ICalculatorViewFactory CreateFactory()
        {
            return new CalculatorViewFactory(resolver);
        }
    }
}