using System.Data;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Workbench.Views;

public partial class WorkbenchView : Form, IWorkbenchView
{
    private readonly IWorkbenchPresenter presenter;

    public WorkbenchView(IWorkbenchPresenter presenter)
    {
        InitializeComponent();
        this.presenter = presenter;
        FormClosed += WinFormsWorkbenchView_FormClosed;
    }

    public IEnumerable<IWorkbenchCommand> Commands
    {
        set
        {
            ToolStripMenuItem fileMenuItem = new()
            {
                Text = "File"
            };

            foreach (var command in value.OrderByDescending(c => c.Priority))
            {
                ToolStripMenuItem menuItem = new()
                {
                    Text = command.Label
                };
                menuItem.Click += delegate
                {
                    command.Execute();
                };
                fileMenuItem.DropDownItems.Add(menuItem);
            }

            menuStrip.Items.Add(fileMenuItem);
        }
    }

    public void Activate(object o)
    {
        var form = (Form)o;
        form.MdiParent = this;
        form.Show();
    }

    private void WinFormsWorkbenchView_Load(object sender, EventArgs e)
    {
        presenter.Initialize();
    }

    private void WinFormsWorkbenchView_FormClosed(object? sender, FormClosedEventArgs e)
    {
        presenter.Close();
    }
}