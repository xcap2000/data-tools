using NSubstitute;
using Xunit;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public partial class GreetingsPresenterFacts
{
    public class TheOnMiddleNameChangedMethod : BaseFacts
    {
        [Fact]
        public void UpdatesModel()
        {
            const string middleName = "Adriano";

            presenter.OnMiddleNameChanged(middleName);

            model.Received().MiddleName = middleName;
        }
    }
}