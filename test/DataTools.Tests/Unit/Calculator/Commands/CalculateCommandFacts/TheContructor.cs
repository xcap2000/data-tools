namespace CarpeDiem.DataTools.Unit.Calculator.Commands;

public static partial class CalculateCommandFacts
{
    public class TheContructor : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void SetsState()
        {
            True(command.Enabled);
            Equal(100, command.Priority);
            Equal(2, command.Label.Length);
            Equal("File", command.Label[0]);
            Equal("Calculate", command.Label[1]);
        }
    }
}