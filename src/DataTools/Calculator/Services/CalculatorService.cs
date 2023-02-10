using System.Threading.Tasks;
using CarpeDiem.DataTools.Calculator.Mappers;
using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Services;

public class CalculatorService : ICalculatorService
{
    private readonly ISumResponseMapper sumResponseMapper;

    public CalculatorService(ISumResponseMapper sumResponseMapper)
    {
        this.sumResponseMapper = sumResponseMapper;
    }

    public Task<ISumResponse> SumAsync(ISumRequest request)
    {
        ISumResponse response;
        try
        {
            string? value1Message = null;
            string? value2Message = null;

            if (!int.TryParse(request.Value1, out int value1)) value1Message = "Value 1 is not a valid integer.";

            if (!int.TryParse(request.Value2, out int value2)) value2Message = "Value 2 is not a valid integer.";

            if (value1Message is not null || value2Message is not null)
            {
                response = sumResponseMapper.ForFailure(value1Message, value2Message, "One or more values are incorrect.");
            }
            else
            {
                response = sumResponseMapper.ForSuccess(checked(value1 + value2).ToString());
            }
        }
        catch
        {
            response = sumResponseMapper.ForFailure(message: $"Overflow ocurred while summing {request.Value1} and {request.Value2}.");
        }
        return Task.FromResult(response);
    }
}