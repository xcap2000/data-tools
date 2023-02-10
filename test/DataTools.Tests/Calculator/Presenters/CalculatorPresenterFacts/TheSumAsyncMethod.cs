using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public static partial class CalculatorPresenterFacts
{
    public class TheSumMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void UpdatesModel()
        {
            var request = For<ISumRequest>();

            sumRequestMapper.Map(model.Value1, model.Value2)
                .Returns(request);

            var response = For<ISumResponse>();

            service.SumAsync(request)
                .Returns(response);

            presenter.Sum(null, EventArgs.Empty);

            sumRequestMapper.Received(1).Map(model.Value1, model.Value2);

            service.Received(1).SumAsync(request);

            calculatorModelMapper.Received(1).Map(model, response);
        }
    }
}