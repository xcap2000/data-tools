using CarpeDiem.DataTools.Workbench.Events;
using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Workbench.Presenters;

public static partial class WorkbenchPresenterFacts
{
    public class TheInitializeMethod : BaseFacts
    {
        [Fact]
        public void InitializesCommands()
        {
            var @event = new ActivatedEvent();
            eventAggregator.GetEvent<ActivatedEvent>().Returns(@event);

            presenter.Initialize();

            view.Received(1).Commands = commands;
            eventAggregator.Received(1).GetEvent<ActivatedEvent>();
            @event.Contains(o => view.Activate(o));
        }
    }
}