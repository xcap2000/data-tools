using System.Threading.Tasks;
using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Services;

public interface ICalculatorService
{
    Task<ISumResponse> SumAsync(ISumRequest request);
}