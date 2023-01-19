namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheExecuteMethod : BaseFacts
    {
        [Fact]
        public void QuitsApplication()
        {
            command.Execute();

            adapter.Received().Quit();
        }
    }
}