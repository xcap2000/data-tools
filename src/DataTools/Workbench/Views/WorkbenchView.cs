using System.Data;
using System.Windows.Forms;
using CarpeDiem.DataTools.Common.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;

namespace CarpeDiem.DataTools.Workbench.Views;

public partial class WorkbenchView : Form, IWorkbenchView
{
    private readonly IWorkbenchPresenter presenter;

    public WorkbenchView(IWorkbenchPresenter presenter)
    {
        InitializeComponent();
        this.presenter = presenter;
        FormClosed += WorkbenchView_FormClosed;
    }

    public IEnumerable<ICommand> Commands
    {
        set
        {
            foreach (var command in value.OrderByDescending(c => c.Priority))
            {
                for (int index = 0; index < command.Label.Length; index++)
                {
                    if (index == 0)
                    {
                        var label = command.Label[index];

                        var controlName = CreateControlName(label, nameof(ToolStripMenuItem));

                        var itemsFound = menuStrip.Items.Find(controlName, true);

                        if (itemsFound.Length == 0)
                        {
                            menuStrip.Items.Add(CreateToolStripMenuItem(controlName, label));
                        }
                    }
                    else
                    {
                        var previousLabel = command.Label[index - 1];

                        var previousControlName = CreateControlName(previousLabel, nameof(ToolStripMenuItem));

                        var toolStripMenuItem = (ToolStripMenuItem)menuStrip.Items.Find(previousControlName, true)[0];

                        var label = command.Label[index];

                        var controlName = CreateControlName(label, nameof(ToolStripMenuItem));

                        var itemsFound = toolStripMenuItem.DropDownItems.Find(controlName, true);

                        if (itemsFound.Length == 0)
                        {
                            toolStripMenuItem.DropDownItems.Add(CreateToolStripMenuItem(controlName, label, command.Execute));
                        }
                    }
                }
            }
        }
    }

    private static ToolStripMenuItem CreateToolStripMenuItem(string controlName, string controlText, Action? execute = null)
    {
        var toolStripMenuItem = new ToolStripMenuItem
        {
            Name = controlName,
            Text = controlText
        };

        if (execute is not null)
        {
            toolStripMenuItem.Click += delegate
            {
                execute();
            };
        }

        return toolStripMenuItem;
    }

    private static string CreateControlName(string label, string controlName)
    {
        return label.ToLower() + controlName;
    }

    public void Activate(object o)
    {
        var form = (Form)o;
        form.MdiParent = this;
        form.Show();
    }

    private void WorkbenchView_Load(object sender, EventArgs e)
    {
        presenter.Initialize();
    }

    private void WorkbenchView_FormClosed(object? sender, FormClosedEventArgs e)
    {
        presenter.Close();
    }
}