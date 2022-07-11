using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Views;
using static NSubstitute.Substitute;

namespace CarpeDiem.DataTools.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly IWorkbenchView view;
        protected readonly IEnumerable<IWorkbenchCommand> commands;
        protected readonly IWorkbenchPresenter presenter;

        protected BaseFacts()
        {
            view = For<IWorkbenchView>();
            commands = For<IEnumerable<IWorkbenchCommand>>();
            // TODO - Fix test.
            presenter = new WorkbenchPresenter(view, commands, null);
        }
    }
}