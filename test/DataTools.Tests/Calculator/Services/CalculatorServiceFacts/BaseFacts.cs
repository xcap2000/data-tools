using CarpeDiem.DataTools.Calculator.Services;

namespace CarpeDiem.DataTools.Calculator;

public static partial class CalculatorServiceFacts
{
    [Collection(CalculatorCollection.NAME)]
    public abstract class BaseFacts
    {
        protected readonly ICalculatorService service;

        protected BaseFacts(CalculatorFixture fixture)
        {
            service = fixture.Container.Resolve<ICalculatorService>();
        }
    }
}