using System.ComponentModel;

namespace CarpeDiem.DataTools.Calculator.Models;

public interface ICalculatorModel : INotifyPropertyChanged, IDataErrorInfo
{
    string Value1 { get; set; }
    string Value2 { get; set; }
    string Result { get; set; }
    string Message { get; set; }
}