using CarpeDiem.DataTools.Calculator.Views;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Events;
using Prism.Events;

namespace CarpeDiem.DataTools.Calculator.Commands;

public class CalculateCommand : IWorkbenchCommand
{
    private readonly IEventAggregator eventAggregator;
    private readonly ILifetimeScope scope;

    public CalculateCommand
    (
        IEventAggregator eventAggregator,
        // TODO - Use factory instead.
        ILifetimeScope scope
    )
    {
        this.eventAggregator = eventAggregator;
        this.scope = scope;
    }

    public int Priority { get; } = 100;

    public string Label => "Calculate";

    public string[] Hierarchy => new[] { "File" };

    public void Execute()
    {
        // TODO - Trigger view created.
        // TODO - Trigger view activated.
        // TODO - Trigger view deactivated.
        // TODO - Trigger view destroyed.

        eventAggregator.GetEvent<ActivatedEvent>().Publish(scope.Resolve<ICalculatorView>());
    }
}