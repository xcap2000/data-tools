using CarpeDiem.DataTools.Common.Commands;
using CarpeDiem.DataTools.Tasks.Factories;
using CarpeDiem.DataTools.Workbench.Events;
using Prism.Events;

namespace CarpeDiem.DataTools.Calculator.Commands;

public class TasksCommand : BaseCommand
{
    private readonly IEventAggregator eventAggregator;
    private readonly ITasksViewFactory factory;

    public TasksCommand
    (
        IEventAggregator eventAggregator,
        ITasksViewFactory factory
    )
        : base(200, "File", "Tasks")
    {
        this.eventAggregator = eventAggregator;
        this.factory = factory;
    }

    public override void Execute()
    {
        // TODO - Trigger view created.
        // TODO - Trigger view activated.
        // TODO - Trigger view deactivated.
        // TODO - Trigger view destroyed.

        eventAggregator.GetEvent<ActivatedEvent>().Publish(factory.Create());

        // TODO - Enable only when the form is closed/hidden.
        Enabled = true;
    }
}