using System.ComponentModel;

namespace CarpeDiem.DataTools.Calculator.Models;

public interface ICalculatorModel : INotifyPropertyChanged
{
    string Value1 { get; set; }
    string Value2 { get; set; }
    string Result { get; set; }
}