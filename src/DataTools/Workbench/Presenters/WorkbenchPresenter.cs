using System.Collections.Generic;
using CarpeDiem.DataTools.Common.Adapters;
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
        private readonly IApplicationAdapter application;

        public WorkbenchPresenter
        (
            IWorkbenchView view,
            IEnumerable<IWorkbenchCommand> commands,
            IEventAggregator eventAggregator,
            IApplicationAdapter application
        )
        {
            this.view = view;
            this.commands = commands;
            this.eventAggregator = eventAggregator;
            this.application = application;
        }

        public void Initialize()
        {
            view.Commands = commands;
            eventAggregator?.GetEvent<ActivatedEvent>().Subscribe(o => view.Activate(o));
        }

        public void Close()
        {
            application.Quit();
        }
    }
}