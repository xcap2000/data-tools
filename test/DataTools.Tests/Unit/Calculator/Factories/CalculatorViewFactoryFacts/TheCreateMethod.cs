namespace CarpeDiem.DataTools.Unit.Calculator.Factories;

public static partial class CalculatorViewFactoryFacts
{
    public class TheCreateMethod : BaseFacts
    {
        [Fact]
        public void TestName()
        {
            // Given
            var expectedView = For<ICalculatorView>();
            resolver.Resolve().Returns(expectedView);

            // When
            var actualView = factory.Create();

            // Then
            Same(expectedView, actualView);
        }
    }
}