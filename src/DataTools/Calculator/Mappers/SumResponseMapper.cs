using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public class SumResponseMapper : ISumResponseMapper
{
    private readonly ISumResponseFactory factory;

    public SumResponseMapper(ISumResponseFactory factory)
    {
        this.factory = factory;
    }

    public ISumResponse ForSuccess(string result)
    {
        var response = factory.Create();
        response.Succeeded = true;
        response.Result = result;
        return response;
    }

    public ISumResponse ForFailure(string? value1 = null, string? value2 = null, string? message = null)
    {
        var response = factory.Create();
        response.Succeeded = false;
        response.Value1Message = value1 ?? "";
        response.Value2Message = value2 ?? "";
        response.Message = message ?? "";
        return response;
    }
}