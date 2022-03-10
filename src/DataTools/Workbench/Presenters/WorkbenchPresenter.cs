using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Views;

namespace CarpeDiem.DataTools.Workbench.Presenters
{
    public class WorkbenchPresenter : IWorkbenchPresenter
    {
        private readonly IWorkbenchView view;
        private readonly IEnumerable<IWorkbenchCommand> commands;

        public WorkbenchPresenter
        (
            IWorkbenchView view,
            IEnumerable<IWorkbenchCommand> commands
        )
        {
            this.view = view;
            this.commands = commands;
        }

        public void Initialize()
        {
            view.Commands = commands;
        }
    }
}