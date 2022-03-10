using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public class TheInitializeMethod : BaseFacts
    {
        [Fact]
        public void InitializesCommands()
        {
            presenter.Initialize();

            view.Received().Commands = commands;
        }
    }
}