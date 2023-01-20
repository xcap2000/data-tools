using System.ComponentModel;

namespace CarpeDiem.DataTools.Common.Commands;

public interface ICommand : INotifyPropertyChanged
{
    int Priority { get; }
    string[] Label { get; }
    public bool Enabled { get; }

    void Execute();
}