using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Workbench.Views;

public partial class WinFormsWorkbenchView : Form, IWorkbenchView
{
    private readonly IWorkbenchPresenter presenter;

    public WinFormsWorkbenchView(IWorkbenchPresenter presenter)
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
        var control = (Control)o;
        control.Dock = DockStyle.Fill;

        toolStripContainer.ContentPanel.Controls.Add(control);
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