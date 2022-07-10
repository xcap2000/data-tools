using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public static partial class MiniCalcPresenterFacts
{
    public class TheSumMethod : BaseFacts
    {
        [Fact]
        public void CalculatesSum()
        {
            const string value1 = "1";
            const string value2 = "2";
            const string result = "3";

            view.Value1.Returns(value1);
            view.Value2.Returns(value2);
            service.Sum(int.Parse(value1), int.Parse(value2))
                .Returns(int.Parse(result));

            presenter.Sum();

            service.Received().Sum(int.Parse(value1), int.Parse(value2));
            view.Received().Result = result;
        }
    }
}