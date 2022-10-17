using System;
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

        // TODO - Test when value1 or value2 is invalid, use error provider on the view.
        // TODO - Use on the service the request/response model.
        // TODO - The service should receive int and return int.
        // TODO - The model sould use string and set itself to an invalid state that would set the error provider when int not parseable, use tryparse.
        // TODO - As the API should use int.
        // TODO - Service should return an overflow message to be set on the view? or should we limit the max integer number?
    }
}