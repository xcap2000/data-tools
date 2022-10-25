using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public class CalculatorModelMapper : ICalculatorModelMapper
{
    public void Map(ICalculatorModel model, ISumResponse response)
    {
        model.Value1Message = response.Value1Message;
        model.Value2Message = response.Value2Message;
        model.Message = response.Message;

        if (response.Succeeded)
            model.Result = response.Result;
    }
}