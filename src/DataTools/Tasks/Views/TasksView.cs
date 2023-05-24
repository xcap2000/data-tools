using System.Windows.Forms;
using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Presenters;

namespace CarpeDiem.DataTools.Tasks.Views;

public partial class TasksView : Form, ITasksView
{
    private readonly ITasksModel model;

    public TasksView(ITasksModel model)
    {
        InitializeComponent();
        this.model = model;
    }

    public void Bind()
    {
        taskDataGridView.ColumnCount = 1;
        taskDataGridView.Columns[0].Name = "ID";
        taskDataGridView.DataSource = model;
    }
}
