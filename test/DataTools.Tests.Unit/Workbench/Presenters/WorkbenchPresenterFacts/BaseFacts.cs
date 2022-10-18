using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Views;
using Prism.Events;

namespace CarpeDiem.DataTools.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly IWorkbenchView view;
        protected readonly IEnumerable<IWorkbenchCommand> commands;
        protected readonly IEventAggregator eventAggregator;
        protected readonly IApplicationAdapter application;
        protected readonly IWorkbenchPresenter presenter;

        protected BaseFacts()
        {
            view = For<IWorkbenchView>();
            commands = For<IEnumerable<IWorkbenchCommand>>();
            eventAggregator = For<IEventAggregator>();
            application = For<IApplicationAdapter>();
            presenter = new WorkbenchPresenter(view, commands, eventAggregator, application);
        }
    }
}