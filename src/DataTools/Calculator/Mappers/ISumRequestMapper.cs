using CarpeDiem.DataTools.Calculator.Requests;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public interface ISumRequestMapper
{
    ISumRequestReader Map(int value1, int value2);
}