using System.ComponentModel;

namespace CarpeDiem.DataTools.Calculator.Models;

public interface ICalculatorModel : INotifyPropertyChanged
{
    string Value1 { get; set; }
    string Value2 { get; set; }
    string Result { get; set; }
    string Message { get; set; }
    string Value1Message { get; set; }
    string Value2Message { get; set; }
}