namespace CarpeDiem.DataTools.Calculator.Presenters;

public static partial class CalculatorPresenterFacts
{
    public class TheInitializeMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void BindsModel()
        {
            presenter.Initialize();

            view.Received(1).Bind();
        }
    }
}