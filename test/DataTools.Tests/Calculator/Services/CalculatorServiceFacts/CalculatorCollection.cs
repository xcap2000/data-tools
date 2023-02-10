namespace CarpeDiem.DataTools.Calculator.Services;

[CollectionDefinition(NAME)]
public class CalculatorCollection : ICollectionFixture<CalculatorFixture>
{
    public const string NAME = nameof(CalculatorCollection);
}