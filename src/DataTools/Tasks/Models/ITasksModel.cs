using System.ComponentModel;

namespace CarpeDiem.DataTools.Tasks.Models;

public interface ITasksModel : ICollection<ITaskModel>, IBindingList
{
    int Page { get; }
    int PageSize { get; }
}