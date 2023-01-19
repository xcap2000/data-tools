using System.Windows.Forms;
using CarpeDiem.DataTools.Tasks.Models;

namespace CarpeDiem.DataTools.Tasks.Views;

public partial class TasksView : Form, ITasksView
{
    public TasksView()
    {
        InitializeComponent();
    }

    // TODO - Review implementation.
    public ITasksModel Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
