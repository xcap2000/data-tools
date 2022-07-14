using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public partial class GreetingsPresenterFacts
{
    public class TheOnLastNameChangedMethod : BaseFacts
    {
        [Fact]
        public void UpdatesModel()
        {
            const string lastName = "Portes";

            presenter.OnLastNameChanged(lastName);

            model.Received().LastName = lastName;
        }
    }
}