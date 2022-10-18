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

    public ISumRequestReader Map(int value1, int value2)
    {
        var request = factory.Create();
        var writer = request as ISumRequestWriter;
        writer.Value1 = value1;
        writer.Value2 = value2;
        return request;
    }
}