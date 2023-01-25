namespace CarpeDiem.DataTools.Unit.Calculator.Commands;

public static partial class CalculateCommandFacts
{
    public class TheExecuteMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void PublishesActivatedEvent()
        {
            // Given
            var @event = For<ActivatedEvent>();
            eventAggregator.GetEvent<ActivatedEvent>().Returns(@event);
            var view = For<ICalculatorView>();
            factory.Create().Returns(view);

            // When
            command.Execute();

            // Then
            eventAggregator.Received(1).GetEvent<ActivatedEvent>();
            @event.Received(1).Publish(view);
            True(command.Enabled);
        }
    }
}