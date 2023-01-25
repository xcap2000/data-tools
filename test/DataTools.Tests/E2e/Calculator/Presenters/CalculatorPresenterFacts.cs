using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.E2e.Calculator.Presenters;

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
        [Trait("Category", "e2e")]
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
        [Trait("Category", "e2e")]
        public void UpdatesModel()
        {
            model.Value1 = "5";
            model.Value2 = "5";

            presenter.Sum(null, EventArgs.Empty);

            Equal("10", model.Result);
        }

        [Fact]
        [Trait("Category", "e2e")]
        public void UpdatesModelValue1Error()
        {
            model.Value1 = "abc";
            model.Value2 = "5";

            presenter.Sum(null, EventArgs.Empty);

            Equal("Value 1 is not a valid integer.", model.Value1Message);
        }

        [Fact]
        [Trait("Category", "e2e")]
        public void UpdatesModelValue2Error()
        {
            model.Value1 = "5";
            model.Value2 = "abc";

            presenter.Sum(null, EventArgs.Empty);

            Equal("Value 2 is not a valid integer.", model.Value2Message);
        }

        [Fact]
        [Trait("Category", "e2e")]
        public void SetsModelMessage()
        {
            model.Value1 = "2147483647";
            model.Value2 = "2147483647";

            presenter.Sum(null, EventArgs.Empty);

            Equal("Overflow ocurred while summing 2147483647 and 2147483647.", model.Message);
        }

        // TODO - Develop in a way that favors tests and coverage

        // TODO - Check overall tests that can be added to calculator and improve coverage
    }
}