using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Events;
using CarpeDiem.DataTools.Workbench.Views;
using Prism.Events;

namespace CarpeDiem.DataTools.Workbench.Presenters
{
    public class WorkbenchPresenter : IWorkbenchPresenter
    {
        private readonly IWorkbenchView view;
        private readonly IEnumerable<IWorkbenchCommand> commands;
        private readonly IEventAggregator eventAggregator;

        public WorkbenchPresenter
        (
            IWorkbenchView view,
            IEnumerable<IWorkbenchCommand> commands,
            IEventAggregator eventAggregator
        )
        {
            this.view = view;
            this.commands = commands;
            this.eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            view.Commands = commands;
            eventAggregator.GetEvent<ActivatedEvent>().Subscribe(o => view.Activate(o));
        }
    }
}