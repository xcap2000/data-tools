using CarpeDiem.DataTools.Calculator.Views;
using CarpeDiem.DataTools.Common.Factories;
using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Calculator.Factories;

public class CalculatorViewFactory : BaseFactory<ICalculatorView>, ICalculatorViewFactory
{
    public CalculatorViewFactory(IResolver<ICalculatorView> resolver)
        : base(resolver)
    {
    }
}