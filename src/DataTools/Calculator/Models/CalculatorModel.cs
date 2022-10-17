using CarpeDiem.DataTools.Common.Models;

namespace CarpeDiem.DataTools.Calculator.Models;

public class CalculatorModel : BaseModel, ICalculatorModel
{
    public string result = "";
    public string value1 = "";
    public string value2 = "";

    public string Value1
    {
        get
        {
            return value1;
        }
        set
        {
            value1 = value;
            OnPropertyChanged(nameof(Value1));
        }
    }

    public string Value2
    {
        get
        {
            return value2;
        }
        set
        {
            value2 = value;
            OnPropertyChanged(nameof(Value2));
        }
    }

    public string Result
    {
        get
        {
            return result;
        }
        set
        {
            result = value;
            OnPropertyChanged(nameof(Result));
        }
    }
}