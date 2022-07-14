using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public partial class GreetingsPresenterFacts
{
    public class TheGreetMethod : BaseFacts
    {
        [Fact]
        public void UpdatesView()
        {
            const string message = "Message";
            model.Greet().Returns(message);

            presenter.Greet();

            model.Received().Greet();
            view.Received().Message = message;
        }
    }
}