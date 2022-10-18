using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public interface ICalculatorModelMapper
{
    void Map(ICalculatorModel model, ISumResponseReader response);
}