namespace CarpeDiem.DataTools.E2e.Calculator;

[CollectionDefinition(NAME)]
public class CalculatorCollection : ICollectionFixture<CalculatorFixture>
{
    public const string NAME = nameof(CalculatorCollection);
}