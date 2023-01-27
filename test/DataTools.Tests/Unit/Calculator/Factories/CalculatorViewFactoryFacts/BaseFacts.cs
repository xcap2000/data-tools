using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Unit.Calculator.Factories;

public static partial class CalculatorViewFactoryFacts
{
    public abstract class BaseFacts
    {
        protected readonly IResolver<ICalculatorView> resolver;
        protected readonly ICalculatorViewFactory factory;

        protected BaseFacts()
        {
            resolver = For<IResolver<ICalculatorView>>();
            factory = new CalculatorViewFactory(resolver);
        }
    }
}