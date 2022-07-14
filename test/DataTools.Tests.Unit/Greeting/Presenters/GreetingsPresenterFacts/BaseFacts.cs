using CarpeDiem.DataTools.Greeting.Model;
using CarpeDiem.DataTools.Greeting.View;
using static NSubstitute.Substitute;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public partial class GreetingsPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly IGreetingsView view;
        protected readonly IGreetingsModel model;
        protected readonly IGreetingsPresenter presenter;

        protected BaseFacts()
        {
            view = For<IGreetingsView>();
            model = For<IGreetingsModel>();
            presenter = new GreetingsPresenter(view, model);
        }
    }
}