using System.Windows.Forms;
using CarpeDiem.DataTools.Tasks.Models;

namespace CarpeDiem.DataTools.Tasks.Views;

public partial class TaskListView : UserControl
{
    public TaskListView()
    {
        InitializeComponent();
    }

    public ITasksModel DataSource
    {
        set
        {
            foreach (var task in value.Tasks)
            {
                var taskView = new TaskView
                {
                    DataSource = task,
                    Dock = DockStyle.Bottom
                };
                tasksPanel.Controls.Add(taskView);
            }
        }
    }
}
