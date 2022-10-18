using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public interface ISumResponseMapper
{
    ISumResponseReader ForSuccess(int result);
    ISumResponseReader ForFailure(string message);
}