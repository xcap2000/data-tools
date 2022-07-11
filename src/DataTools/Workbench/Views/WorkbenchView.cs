using System;
using System.Collections.Generic;
using System.Linq;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using Gtk;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public class WorkbenchView : Window, IWorkbenchView
    {
        [Builder.Object]
        private readonly MenuBar? menuBar = null;

        [Builder.Object]
        private readonly Box? box = null;
        private readonly IWorkbenchPresenter presenter;

        public WorkbenchView(IWorkbenchPresenter presenter)
            : this(new Builder(nameof(WorkbenchView) + ".glade"), presenter)
        {
            Shown += WorkbenchView_Shown;
        }

        private WorkbenchView
        (
            Builder builder,
            IWorkbenchPresenter presenter
        )
            : base(builder.GetRawOwnedObject(nameof(WorkbenchView)))
        {
            builder.Autoconnect(this);
            this.presenter = presenter;
        }

        public IEnumerable<IWorkbenchCommand> Commands
        {
            set
            {
                Menu fileMenu = new();
                fileMenu.Visible = true;

                MenuItem fileMenuItem = new("File")
                {
                    Visible = true,
                    Submenu = fileMenu
                };

                foreach (var command in value)
                {
                    var menuItem = new MenuItem(command.Label);
                    menuItem.Activated += delegate
                    {
                        command.Execute();
                    };
                    menuItem.Visible = true;
                    fileMenu.Append(menuItem);
                }

                menuBar!.Append(fileMenuItem);
            }
        }

        public void Activate(object o)
        {
            foreach (var widget in box!.Children)
            {
                box.Remove(widget);
            }
            box!.PackStart((Widget)o, true, true, 0);
        }

        private void WorkbenchView_Shown(object? sender, EventArgs a)
        {
            presenter.Initialize();
        }
    }
}