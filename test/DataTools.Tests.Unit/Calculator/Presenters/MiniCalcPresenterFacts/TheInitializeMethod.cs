namespace CarpeDiem.DataTools.Calculator.Presenters;

public static partial class MiniCalcPresenterFacts
{
    public class TheInitializeMethod : BaseFacts
    {
        [Fact]
        public void SetsDefaultValues()
        {
            presenter.Initialize();

            view.Received().Value1 = "";
            view.Received().Value2 = "";
            view.Received().Result = "";
        }
    }
}