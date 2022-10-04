using System;
using System.Collections.Generic;
using System.Linq;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace CarpeDiem.DataTools.Workbench.Views;

public class WorkbenchView : Window, IWorkbenchView
{
    [UI] private readonly MenuBar menuBar = null!;

    [UI] private readonly Box box = null!;

    private readonly IWorkbenchPresenter presenter;

    public WorkbenchView(IWorkbenchPresenter presenter)
        : this(new Builder(nameof(WorkbenchView) + ".glade"), presenter)
    {
        Shown += WorkbenchView_Shown;
    }

    private WorkbenchView(Builder builder, IWorkbenchPresenter presenter)
        : base(builder.GetRawOwnedObject(nameof(WorkbenchView)))
    {
        builder.Autoconnect(this);
        this.presenter = presenter;
        this.DeleteEvent += WorkbenchView_DeleteEvent;
    }

    public IEnumerable<IWorkbenchCommand> Commands
    {
        set
        {
            Menu fileMenu = new()
            {
                Visible = true
            };

            MenuItem fileMenuItem = new("File")
            {
                Visible = true,
                Submenu = fileMenu
            };

            foreach (var command in value.OrderByDescending(c => c.Priority))
            {
                var menuItem = new MenuItem(command.Label);
                menuItem.Activated += delegate
                {
                    command.Execute();
                };
                menuItem.Visible = true;
                fileMenu.Append(menuItem);
            }

            menuBar.Append(fileMenuItem);
        }
    }

    public void Activate(object o)
    {
        foreach (var widget in box.Children)
        {
            box.Remove(widget);
        }
        box.PackStart((Widget)o, true, true, 0);
    }

    private void WorkbenchView_Shown(object? sender, EventArgs a)
    {
        presenter.Initialize();
    }

    private void WorkbenchView_DeleteEvent(object o, DeleteEventArgs args)
    {
        presenter.Close();
    }
}