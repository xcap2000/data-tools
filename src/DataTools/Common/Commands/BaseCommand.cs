using System.ComponentModel;

namespace CarpeDiem.DataTools.Common.Commands;

public abstract class BaseCommand : ICommand
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private bool enabled = true;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public abstract void Execute();

    public bool Enabled
    {
        get
        {
            return enabled;
        }
        set
        {
            enabled = value;
            OnPropertyChanged(nameof(Enabled));
        }
    }

    public abstract int Priority { get; }

    public abstract string Label { get; }
}