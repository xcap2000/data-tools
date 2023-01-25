using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Common.Commands;
using Prism.Events;

namespace CarpeDiem.DataTools.Unit.Calculator.Commands;

public static partial class CalculateCommandFacts
{
    public abstract class BaseFacts
    {
        protected readonly IEventAggregator eventAggregator;
        protected readonly ICalculatorViewFactory factory;
        protected readonly ICommand command;

        protected BaseFacts()
        {
            eventAggregator = For<IEventAggregator>();
            factory = For<ICalculatorViewFactory>();
            command = new CalculateCommand(eventAggregator, factory);
        }
    }
}