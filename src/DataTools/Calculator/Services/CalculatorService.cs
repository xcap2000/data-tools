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

    public ISumResponseReader Sum(ISumRequestReader request)
    {
        try
        {
            return sumResponseMapper.ForSuccess(checked(request.Value1 + request.Value2));
        }
        catch
        {
            return sumResponseMapper.ForFailure($"Overflow ocurred while summing {request.Value1} and {request.Value2}.");
        }
    }
}