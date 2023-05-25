using System.ComponentModel;

namespace CarpeDiem.DataTools.Tasks.Models;

public interface ITaskModel : INotifyPropertyChanged
{
    Guid Id { get; }
}