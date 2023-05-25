using System.Windows.Forms;
using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Presenters;

namespace CarpeDiem.DataTools.Tasks.Views;

public partial class TasksView : Form, ITasksView
{
    private readonly ITasksModel model;
    private readonly ITasksPresenter presenter;

    public TasksView
    (
        ITasksModel model,
        ITasksPresenter presenter
    )
    {
        InitializeComponent();
        this.model = model;
        this.presenter = presenter;
    }

    public void Bind()
    {
        taskDataGridView.DataSource = model;
    }

    private async void TasksView_Load(object sender, EventArgs e)
    {
        await presenter.InitializeAsync();
    }
}
