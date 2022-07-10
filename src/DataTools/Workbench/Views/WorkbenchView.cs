using System;
using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using Gtk;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public class WorkbenchView : Window, IWorkbenchView
    {
        [Builder.Object]
        private readonly MenuBar? menuBar = null;
        private readonly IWorkbenchPresenter presenter;

        public WorkbenchView(IWorkbenchPresenter presenter)
            : this(new Builder("WorkbenchView.glade"))
        {
            this.presenter = presenter;
            Shown += WorkbenchView_Shown;
        }

        private WorkbenchView(Builder builder)
            : base(builder.GetRawOwnedObject("WorkbenchView"))
        {
            builder.Autoconnect(this);
        }

        public IEnumerable<IWorkbenchCommand> Commands
        {
            set
            {
                foreach (var command in value)
                {
                    var menuItem = new MenuItem(command.Label);
                    menuItem.Activated += delegate
                    {
                        command.Execute();
                    };
                    menuItem.Visible = true;
                    menuBar!.Add(menuItem);
                }
            }
        }

        private void WorkbenchView_Shown(object? sender, EventArgs a)
        {
            presenter.Initialize();
        }
    }
}