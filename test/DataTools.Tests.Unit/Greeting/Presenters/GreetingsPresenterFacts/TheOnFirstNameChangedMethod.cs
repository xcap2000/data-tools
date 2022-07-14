using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public partial class GreetingsPresenterFacts
{
    public class TheOnFirstNameChangedMethod : BaseFacts
    {
        [Fact]
        public void UpdatesModel()
        {
            const string firstName = "Carlos";

            presenter.OnFirstNameChanged(firstName);

            model.Received().FirstName = firstName;
        }
    }
}