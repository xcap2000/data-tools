using CarpeDiem.DataTools.Calculator.Requests;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public interface ISumRequestMapper
{
    ISumRequest Map(string value1, string value2);
}