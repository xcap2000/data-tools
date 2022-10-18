using System.ComponentModel;

namespace CarpeDiem.DataTools.Common.Models;

public abstract class BaseModel : INotifyPropertyChanged, IDataErrorInfo
{
    private readonly Dictionary<string, string> errors = new Dictionary<string, string>();

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected void AddError(string columnName, string errorMessage)
    {
        if (!errors.ContainsKey(columnName))
        {
            errors.Add(columnName, errorMessage);
        }
        else
        {
            errors[columnName] = errorMessage;
        }
    }

    protected void RemoveError(string columnName)
    {
        errors.Remove(columnName);
    }

    public string Error
    {
        get
        {
            return string.Join('\n', errors.ToArray());
        }
    }

    public string this[string columnName]
    {
        get
        {
            if (errors.ContainsKey(columnName))
            {
                return errors[columnName];
            }

            return string.Empty;
        }
    }
}