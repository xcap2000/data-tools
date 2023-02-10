namespace CarpeDiem.DataTools.Calculator.Services;

public static partial class CalculatorServiceFacts
{
    public class TheSumMethod : BaseFacts
    {
        public TheSumMethod(CalculatorFixture fixture)
            : base(fixture)
        {
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void FailsForInvalidValue1()
        {
            var request = new SumRequest
            {
                Value1 = "a",
                Value2 = "1"
            };

            var response = await service.SumAsync(request);

            False(response.Succeeded);
            Empty(response.Result);
            Equal("One or more values are incorrect.", response.Message);
            Equal("Value 1 is not a valid integer.", response.Value1Message);
            Empty(response.Value2Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void FailsForInvalidValue2()
        {
            var request = new SumRequest
            {
                Value1 = "1",
                Value2 = "a"
            };

            var response = await service.SumAsync(request);

            False(response.Succeeded);
            Empty(response.Result);
            Equal("One or more values are incorrect.", response.Message);
            Empty(response.Value1Message);
            Equal("Value 2 is not a valid integer.", response.Value2Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void FailsForInvalidValue1AndValue2()
        {
            var request = new SumRequest
            {
                Value1 = "a",
                Value2 = "b"
            };

            var response = await service.SumAsync(request);

            False(response.Succeeded);
            Empty(response.Result);
            Equal("One or more values are incorrect.", response.Message);
            Equal("Value 1 is not a valid integer.", response.Value1Message);
            Equal("Value 2 is not a valid integer.", response.Value2Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void FailsForOverflow()
        {
            var request = new SumRequest
            {
                Value1 = int.MaxValue.ToString(),
                Value2 = int.MaxValue.ToString()
            };

            var response = await service.SumAsync(request);

            False(response.Succeeded);
            Empty(response.Result);
            Equal("Overflow ocurred while summing 2147483647 and 2147483647.", response.Message);
            Empty(response.Value1Message);
            Empty(response.Value2Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void Succeeds()
        {
            var request = new SumRequest
            {
                Value1 = "1",
                Value2 = "2"
            };

            var response = await service.SumAsync(request);

            True(response.Succeeded);
            Equal("3", response.Result);
            Empty(response.Message);
            Empty(response.Value1Message);
            Empty(response.Value2Message);
        }
    }
}