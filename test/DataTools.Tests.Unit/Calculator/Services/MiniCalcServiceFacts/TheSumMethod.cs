using Xunit;
using static Xunit.Assert;

namespace CarpeDiem.DataTools.Calculator.Services;

public partial class MiniCalcServiceFacts
{
    public class TheSumMethod : BaseFacts
    {
        [Fact]
        public void CalculatesSum()
        {
            Equal(3, service.Sum(1, 2));
        }
    }
}