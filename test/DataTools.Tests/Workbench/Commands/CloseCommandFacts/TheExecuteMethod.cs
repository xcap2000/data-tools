namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheExecuteMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void QuitsApplication()
        {
            command.Execute();

            adapter.Received(1).Quit();
        }
    }
}