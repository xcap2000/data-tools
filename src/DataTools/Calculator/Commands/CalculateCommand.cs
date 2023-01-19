using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Common.Commands;
using CarpeDiem.DataTools.Workbench.Events;
using Prism.Events;

namespace CarpeDiem.DataTools.Calculator.Commands;

public class CalculateCommand : BaseCommand, ICommand
{
    private readonly IEventAggregator eventAggregator;
    private readonly ICalculatorViewFactory factory;

    public CalculateCommand
    (
        IEventAggregator eventAggregator,
        ICalculatorViewFactory factory
    )
    {
        this.eventAggregator = eventAggregator;
        this.factory = factory;
    }

    // TODO - Use contructir inheritance to set those properties.
    public override int Priority { get; } = 100;

    public override string Label => "Calculate";

    public override void Execute()
    {
        // TODO - Trigger view created.
        // TODO - Trigger view activated.
        // TODO - Trigger view deactivated.
        // TODO - Trigger view destroyed.

        Enabled = false;

        eventAggregator.GetEvent<ActivatedEvent>().Publish(factory.Create());

        // TODO - Enable only when the form is closed/hidden.
        Enabled = true;
    }
}