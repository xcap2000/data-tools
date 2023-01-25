namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheLabelProperty : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void ReturnsLabel()
        {
            Equal("File", command.Label[0]);
            Equal("Close", command.Label[1]);
        }
    }
}