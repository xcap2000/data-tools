using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Services;

public interface ICalculatorService
{
    ISumResponse Sum(ISumRequest request);
}