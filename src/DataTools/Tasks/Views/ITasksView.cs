using CarpeDiem.DataTools.Tasks.Models;

namespace CarpeDiem.DataTools.Tasks.Views;

public interface ITasksView
{
    ITasksModel Model { get; set; }
}