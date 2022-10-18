using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Responses;

namespace CarpeDiem.DataTools.Calculator.Mappers;

public class CalculatorModelMapper : ICalculatorModelMapper
{
    public void Map(ICalculatorModel model, ISumResponseReader response)
    {
        if (response.Succeeded)
        {
            model.Result = response.Result.ToString();
            model.Message = "";
        }
        else
        {
            model.Message = response.Message;
        }
    }
}