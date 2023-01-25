namespace CarpeDiem.DataTools.E2e.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public class TheCloseMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void QuitsApplication()
        {
            presenter.Close();

            application.Received(1).Quit();
        }
    }
}