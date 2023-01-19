namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheLabelProperty : BaseFacts
    {
        [Fact]
        public void ReturnsLavel()
        {
            Equal("Close", command.Label);
        }
    }
}