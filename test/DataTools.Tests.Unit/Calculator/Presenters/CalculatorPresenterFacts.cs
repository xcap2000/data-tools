using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public static class CalculatorPresenterFacts
{
    [Collection(CalculatorCollection.NAME)]
    public class TheInitializeMethod
    {
        private readonly ICalculatorView view;
        private readonly ICalculatorPresenter presenter;

        public TheInitializeMethod(CalculatorFixture fixture)
        {
            view = fixture.Container.Resolve<ICalculatorView>();
            presenter = fixture.Container.Resolve<ICalculatorPresenter>();
        }

        [Fact]
        public void BindsModel()
        {
            presenter.Initialize();

            view.Received(1).Bind();
        }
    }

    [Collection(CalculatorCollection.NAME)]
    public class TheSumMethod
    {
        private readonly ICalculatorModel model;
        private readonly ICalculatorPresenter presenter;

        public TheSumMethod(CalculatorFixture fixture)
        {
            model = fixture.Container.Resolve<ICalculatorModel>();
            presenter = fixture.Container.Resolve<ICalculatorPresenter>();
        }

        [Fact]
        public void UpdatesModel()
        {
            model.Value1 = "5";
            model.Value2 = "5";

            presenter.Sum(null, EventArgs.Empty);

            Equal("10", model.Result);
        }

        [Fact]
        public void SetsModelMessage()
        {
            model.Value1 = "2147483647";
            model.Value2 = "2147483647";

            presenter.Sum(null, EventArgs.Empty);

            Equal("Overflow ocurred while summing 2147483647 and 2147483647.", model.Message);
        }

        // TODO - Review whether model should be dumb, all validation should take place with service and the
        // model should just fill error messages that are bound to the ui, this would work with the API model
        // where model validation and request takes place. Model would be a mirror of the request/dto. This way
        // validation would be centralized in the service and the model would be dumb/thin without validation logic

        // TODO - Develop in a way that favors tests and coverage

        // TODO - Check overall tests that can be added to calculator and improve coverage
    }
}