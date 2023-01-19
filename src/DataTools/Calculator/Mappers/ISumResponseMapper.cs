using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public interface ISumResponseMapper
{
    ISumResponse ForSuccess(string result);
    ISumResponse ForFailure(string? value1 = null, string? value2 = null, string? message = null);
}