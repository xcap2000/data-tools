using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Calculator.Requests;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public class SumRequestMapper : ISumRequestMapper
{
    private readonly ISumRequestFactory factory;

    public SumRequestMapper(ISumRequestFactory factory)
    {
        this.factory = factory;
    }

    public ISumRequest Map(string value1, string value2)
    {
        var request = factory.Create();
        request.Value1 = value1;
        request.Value2 = value2;
        return request;
    }
}