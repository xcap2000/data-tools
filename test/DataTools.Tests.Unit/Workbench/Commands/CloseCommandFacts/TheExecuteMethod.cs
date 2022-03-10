using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public class TheExecuteMethod : BaseFacts
    {
        [Fact]
        public void TestName()
        {
            command.Execute();

            adapter.Received().Quit();
        }
    }
}