using System.ComponentModel;

namespace CarpeDiem.DataTools.Common.Commands;

public abstract class BaseCommand : ICommand
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private bool enabled = true;

    protected BaseCommand(int priority, params string[] label)
    {
        Priority = priority;
        Label = label;
    }

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

    public int Priority { get; }

    public string[] Label { get; }
}