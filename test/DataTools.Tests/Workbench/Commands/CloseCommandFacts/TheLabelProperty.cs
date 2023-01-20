namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheLabelProperty : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void ReturnsLavel()
        {
            Equal("Close", command.Label);
        }
    }
}