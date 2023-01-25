using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Commands;
using CarpeDiem.DataTools.Workbench.Views;
using Prism.Events;

namespace CarpeDiem.DataTools.E2e.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly IWorkbenchView view;
        protected readonly IEnumerable<ICommand> commands;
        protected readonly IEventAggregator eventAggregator;
        protected readonly IApplicationAdapter application;
        protected readonly IWorkbenchPresenter presenter;

        protected BaseFacts()
        {
            view = For<IWorkbenchView>();
            commands = For<IEnumerable<ICommand>>();
            eventAggregator = For<IEventAggregator>();
            application = For<IApplicationAdapter>();
            presenter = new WorkbenchPresenter(view, commands, eventAggregator, application);
        }
    }
}