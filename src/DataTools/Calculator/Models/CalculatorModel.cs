using CarpeDiem.DataTools.Common.Models;

namespace CarpeDiem.DataTools.Calculator.Models;

public class CalculatorModel : BaseModel, ICalculatorModel
{
    public string result = "";
    public string value1 = "";
    public string value2 = "";
    public string value1Message = "";
    public string value2Message = "";
    public string message = "";

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

    public string Value1Message
    {
        get
        {
            return value1Message;
        }
        set
        {
            value1Message = value;
            OnPropertyChanged(nameof(Value1Message));
        }
    }

    public string Value2Message
    {
        get
        {
            return value2Message;
        }
        set
        {
            value2Message = value;
            OnPropertyChanged(nameof(Value2Message));
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