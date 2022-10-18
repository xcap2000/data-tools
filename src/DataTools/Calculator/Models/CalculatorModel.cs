using CarpeDiem.DataTools.Common.Models;

namespace CarpeDiem.DataTools.Calculator.Models;

public class CalculatorModel : BaseModel, ICalculatorModel
{
    public string result = "";
    public string value1 = "";
    public string value2 = "";
    public string message = "";

    public CalculatorModel()
    {
        AddError(nameof(Value1), "Value 1 is an invalid integer.");
        AddError(nameof(Value2), "Value 2 is an invalid integer.");
    }

    public string Value1
    {
        get
        {
            return value1;
        }
        set
        {
            value1 = value;
            if (!int.TryParse(value1, out _))
            {
                AddError(nameof(Value1), "Value 1 is an invalid integer.");
            }
            else
            {
                RemoveError(nameof(Value1));
            }
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
            if (!int.TryParse(value2, out _))
            {
                AddError(nameof(Value2), "Value 2 is an invalid integer.");
            }
            else
            {
                RemoveError(nameof(Value2));
            }
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

    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
            OnPropertyChanged(nameof(Message));
        }
    }
}