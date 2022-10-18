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

    public ISumResponseReader ForSuccess(int result)
    {
        var response = factory.Create();
        var writer = response as ISumResponseWriter;
        writer.Succeeded = true;
        writer.Result = result;
        return response;
    }

    public ISumResponseReader ForFailure(string message)
    {
        var response = factory.Create();
        var writer = response as ISumResponseWriter;
        writer.Succeeded = false;
        writer.Message = message;
        return response;
    }
}